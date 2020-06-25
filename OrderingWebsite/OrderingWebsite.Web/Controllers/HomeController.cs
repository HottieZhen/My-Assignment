using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderingWebsite.Web.Models;

namespace OrderingWebsite.Web.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "1")]
        public IActionResult Index()
        {
            List<Menu> menus = new List<Menu>()
            {
                    new Menu("订单管理","path","name9", "el-icon-menu","9","0"),
                        new Menu("订单列表","/Order/Index","order","el-icon-location","10","9"),
                    new Menu("菜单管理","path","name3", "el-icon-menu","14","0"),
                        new Menu("菜单列表","/FoodMenu/Index","foodMenu","el-icon-location","10","14"),
                        new Menu("菜品统计","/FoodMenu/Statistics","statistics","el-icon-location","11","14"),
                    new Menu("分类管理","path","name1", "el-icon-menu","1","0" ),
                        new Menu("分类列表","/Category/Index","category","el-icon-location","2","1"),
            };
            ViewData["system_name"] = "吃了么点餐后台管理";
            return View(menus);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
