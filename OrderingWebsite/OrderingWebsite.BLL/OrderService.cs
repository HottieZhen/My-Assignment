using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using OrderingWebsite.BLL;
using OrderingWebsite.BLL.Dto;
using System;
using OrderingWebsite.DAL.Models;

namespace TakeOut.BLL
{
    public class OrderService
    {
        private readonly DataContext _dataContext;

        public OrderService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<OrderDto> GetOrders(QueryDto dto, out int total)
        {

            var data = from a in _dataContext.Orders
                       join d in _dataContext.Users
                       on a.UserId equals d.Id
                       select new OrderDto
                       {
                           Id = a.Id,
                           UserName = d.Name,
                           Address = d.Address,
                           Phone = d.Phone,
                           CreateTime = a.CreateTime,
                           Status = a.Status,
                           Price = a.Price
                       };

            total = data.Count();
            var orders = data.Skip((dto.PageNo - 1) * dto.PageSize).Take(dto.PageSize).ToList();

            var orderIds = orders.Select(x => x.Id).ToList();
            var foods = (from a in _dataContext.Order_Foods.Where(x => orderIds.Contains(x.OrderId))
                         join b in _dataContext.FoodMenus
                         on a.FoodId equals b.Id
                         select new
                         {
                             a.OrderId,
                             b.Name,
                             a.Count
                         }).ToList();

            orders.ForEach(x =>
            {
                var foodList = foods.Where(y => y.OrderId == x.Id)
                    .Select(y => new Tuple<string, int>(y.Name, y.Count)).ToList();
                x.FoodDic = foodList;
            });

            return orders;
        }

        public async Task<bool> UpdateOrderStatus(int orderId, string stauts)
        {
            var order = await _dataContext.Orders.FirstOrDefaultAsync(x => x.Id == orderId);
            if (order == null) return false;

            order.Status = stauts;
            return await _dataContext.SaveChangesAsync() > 0;
        }

        public bool AddOrder(int userId, decimal totalPrice, string foodIds)
        {
            var order = new Order()
            {
                UserId = userId,
                Price = totalPrice,
                Status = "已付款",
                CreateTime = DateTime.Now
            };
            _dataContext.Orders.Add(order);
            _dataContext.SaveChanges();

            var splitedIds = foodIds.Split(',');
            var addedIds = new List<Order_Food>();
            foreach (var id in splitedIds)
            {
                int.TryParse(id, out int foodId);
                var added = addedIds.FirstOrDefault(x => x.FoodId == foodId);
                if (added == null)
                {
                    var orderFood = new Order_Food()
                    {
                        OrderId = order.Id,
                        FoodId = foodId,
                        Count = 1
                    };
                    _dataContext.Order_Foods.Add(orderFood);
                }
                else
                {
                    added.Count++;
                }
            }

            return _dataContext.SaveChanges() > 0;
        }
    }
}
