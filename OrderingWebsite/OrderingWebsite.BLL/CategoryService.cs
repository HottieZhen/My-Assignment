using System;
using System.Collections.Generic;
using System.Linq;
using Data.Models;
using OrderingWebsite.BLL.Dto;
using OrderingWebsite.DAL.Models;

namespace OrderingWebsite.BLL
{
    public class CategoryService
    {
        private readonly DataContext _dataContext;

        public CategoryService(DataContext dataContex)
        {
            _dataContext = dataContex;
        }

        public List<Category> GetCategory()
        {
            var query = _dataContext.Categorys;
            return query.ToList();
        }

        public bool EditCategory(CategoryDto dto)
        {
            if (dto.Id > 0)
            {
                var model = _dataContext.Categorys.FirstOrDefault(x => x.Id == dto.Id);
                if (model == null) return false;
                model.Name = dto.Name;
            }
            else
            {
                var category = new Category()
                {
                    Name = dto.Name,
                };
                _dataContext.Categorys.Add(category);
            }

            return _dataContext.SaveChanges() > 0;
        }

        public bool DeleteCategory(int id)
        {
            var model = _dataContext.Categorys.FirstOrDefault(x => x.Id == id);
            if (model == null) return false;

            _dataContext.Categorys.Remove(model);
            return _dataContext.SaveChanges() > 0;
        }
    }
}
