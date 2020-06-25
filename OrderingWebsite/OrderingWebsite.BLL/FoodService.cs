using System;
using System.Collections.Generic;
using System.Linq;
using Data.Models;
using OrderingWebsite.DAL.Models;

namespace OrderingWebsite.BLL
{
    public class FoodService
    {
        private readonly DataContext _dataContext;

        public FoodService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<FoodMenu> GetFoodMenus(QueryDto filter, out int total)
        {
            var query = _dataContext.FoodMenus;

            var foods = query.Skip((filter.PageNo - 1) * filter.PageSize).Take(filter.PageSize).ToList();
            total = query.Count();
            return foods;
        }

        public int AddFoodMenu(FoodMenuDto food)
        {
            if (food.Id > 0)
            {
                var model = _dataContext.FoodMenus.FirstOrDefault(x => x.Id == food.Id);
                if (model == null) return 0;

                model.ImgUrl = food.ImgUrl;
                model.Name = food.Name;
                model.Description = food.Description;
                model.Type = food.Type;
                model.Price = food.Price;
                model.StockCount = food.StockCount;
            }
            else
            {
                var foodModel = new FoodMenu()
                {
                    Name = food.Name,
                    Description = food.Description,
                    Type = food.Type,
                    ImgUrl = food.ImgUrl,
                    Price = food.Price,
                    StockCount = food.StockCount,
                    CreateTime = DateTime.Now
                };
                _dataContext.FoodMenus.Add(foodModel);
            }

            return _dataContext.SaveChanges();
        }
    }
}
