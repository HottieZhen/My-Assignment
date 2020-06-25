using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OrderingWebsite.BLL;
using OrderingWebsite.Web.Models;

namespace TakeOut.Web.Controllers
{

    public class FoodMenuController : Controller
    {
        private readonly FoodService _foodService;
        private readonly IHostingEnvironment _hostingEnvironment;

        public FoodMenuController(FoodService foodService, IHostingEnvironment hostingEnvironment)
        {
            _foodService = foodService;
            _hostingEnvironment = hostingEnvironment;
        }

        [Authorize(Roles = "1")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "1")]
        public IActionResult Statistics()
        {
            return View();
        }

        [Authorize(Roles = "1")]
        public IActionResult GetFoodMenus(QueryDto filter)
        {
            var foods = _foodService.GetFoodMenus(filter, out int total);
            return Json(new ResponseModel(true, foods, total));
        }

        [Authorize(Roles = "1")]
        public IActionResult GetStatistics(QueryDto filter)
        {
            var foods = _foodService.GetStatistics(filter);
            return Json(new ResponseModel(true, foods, 0));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public ActionResult UploadImg()
        {
            try
            {
                var fileCount = Request.Form.Files.Count;
                if (fileCount == 0) return Json(new { Success = false });

                var file = Request.Form.Files[0];
                var folder = _hostingEnvironment.WebRootPath + "/upload";
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

                return Json(new { Success = true, fileName = $"/upload/{Path.GetFileName(file.FileName)}" });
            }
            catch
            {
                return Json(new { Success = false });
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public ActionResult AddFoodMenu([FromBody] FoodMenuDto food)
        {
            var result = _foodService.AddFoodMenu(food);

            return Json(new ResponseModel(result > 0, null, 0));
        }

        [Authorize(Roles = "1")]
        public IActionResult DeleteFoodMenu(int id)
        {
            var data = _foodService.Delete(id);
            return Json(new ResponseModel(data, null, 0));
        }
    }
}
