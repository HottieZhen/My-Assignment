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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetOrders(QueryDto dto)
        {
            var orders = _orderService.GetOrders(dto, out int total);
            return Json(new ResponseModel(true, orders, total));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStatus(int id, string status)
        {
            return Json(new ResponseModel(await _orderService.UpdateOrderStatus(id, status)));
        }
    }
}