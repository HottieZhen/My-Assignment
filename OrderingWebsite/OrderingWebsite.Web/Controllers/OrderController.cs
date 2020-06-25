using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderingWebsite.BLL;
using OrderingWebsite.Web.Models;
using TakeOut.BLL;

namespace TakeOut.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [Authorize(Roles = "1")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "1")]
        public IActionResult GetOrders(QueryDto dto)
        {
            var orders = _orderService.GetOrders(dto, out int total);
            return Json(new ResponseModel(true, orders, total));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public async Task<IActionResult> UpdateStatus(int id, string status)
        {
            return Json(new ResponseModel(await _orderService.UpdateOrderStatus(id, status)));
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddOrder(int totalPrice, string foodIds)
        {
            var userIdStr = User.Claims.SingleOrDefault(s => s.Type == "UserId").Value;
            int.TryParse(userIdStr, out int userId);

            return Json(new ResponseModel(_orderService.AddOrder(userId, totalPrice, foodIds)));
        }
    }
}