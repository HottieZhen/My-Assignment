using System.IO;
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetFoodMenus(QueryDto filter)
        {
            var foods = _foodService.GetFoodMenus(filter, out int total);
            return Json(new ResponseModel(true, foods, total));
        }

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

        [HttpPost]
        public ActionResult AddFoodMenu([FromBody] FoodMenuDto food)
        {
            var result = _foodService.AddFoodMenu(food);

            return Json(new ResponseModel(result > 0, null, 0));
        }
    }
}
