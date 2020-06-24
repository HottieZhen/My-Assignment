using System;
using System.IO;
using System.Linq;
using Data.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderingWebsite.BLL;
using OrderingWebsite.DAL.Models;

namespace TakeOut.Web.Controllers
{
    public class FoodMenuController : Controller
    {
        private readonly DataContext _dbContext;
        private readonly IHostingEnvironment _hostingEnvironment;

        public FoodMenuController(DataContext dbContex, IHostingEnvironment hostingEnvironment)
        {
            _dbContext = dbContex;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetFoodMenus(QueryDto filter)
        {
            var query = _dbContext.FoodMenus;
            var foods = query.Skip((filter.PageNo - 1) * filter.PageSize).Take(filter.PageSize).ToList();
            return Json(new { Status = "Success", Data = foods, Total = query.Count() });
        }

        [HttpPost]
        public ActionResult UploadImg()
        {
            try
            {
                var fileCount = Request.Form.Files.Count;
                if (fileCount == 0) return Json(new { Success = false });

                var file = Request.Form.Files[0];
                var folder = _hostingEnvironment.WebRootPath + "/img";
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                var physicalPath = Path.Combine(folder, Path.GetFileName(file.FileName));
                using (FileStream fs = System.IO.File.Create(physicalPath))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }

                return Json(new { Success = true, fileName = $"/img/{Path.GetFileName(file.FileName)}" });
            }
            catch
            {
                return Json(new { Success = false });
            }
        }

        [HttpPost]
        public ActionResult AddFood([FromBody] FoodMenuDto food)
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
            _dbContext.FoodMenus.Add(foodModel);

            return Json(new { Success = _dbContext.SaveChanges() > 0 });
        }
    }
}