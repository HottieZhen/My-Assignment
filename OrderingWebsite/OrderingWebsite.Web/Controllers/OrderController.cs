using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using OrderingWebsite.BLL;
using OrderingWebsite.Web.Models;

namespace TakeOut.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly DataContext _dataContext;

        public OrderController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetOrders(QueryDto dto)
        {
            var data = from a in _dataContext.Orders
                       join d in _dataContext.Users
                       on a.UserId equals d.Id
                       select new
                       {
                           Id = a.Id,
                           UserName = d.Name,
                           Address = d.Address,
                           a.CreateTime,
                           a.Status,
                           a.Price
                       };

            var orders = data.Skip((dto.PageNo - 1) * dto.PageSize).Take(dto.PageSize).ToList();
            return Json(new ResponseModel(true, orders, data.Count()));
        }

        [HttpPost]
        public IActionResult UpdateStatus(int id, string status)
        {
            var order = _dataContext.Orders.FirstOrDefault(x => x.Id == id);
            if (order != null)
            {
                order.Status = status;
                _dataContext.SaveChanges();
            }

            return Json(new ResponseModel(true));
        }
    }
}