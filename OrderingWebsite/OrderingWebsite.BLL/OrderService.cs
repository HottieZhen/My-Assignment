using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using OrderingWebsite.BLL;
using OrderingWebsite.BLL.Dto;

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
                           CreateTime = a.CreateTime,
                           Status = a.Status,
                           Price = a.Price
                       };

            total = data.Count();
            var orders = data.Skip((dto.PageNo - 1) * dto.PageSize).Take(dto.PageSize).ToList();
            return orders;
        }

        public async Task<bool> UpdateOrderStatus(int orderId, string stauts)
        {
            var order = await _dataContext.Orders.FirstOrDefaultAsync(x => x.Id == orderId);
            if (order == null) return false;

            order.Status = stauts;
            return await _dataContext.SaveChangesAsync() > 0;
        }
    }
}
