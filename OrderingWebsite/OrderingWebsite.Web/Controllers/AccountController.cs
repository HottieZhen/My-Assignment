using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using OrderingWebsite.BLL;
using OrderingWebsite.Web.Models;

namespace OrderingWebsite.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountService _Service;

        public AccountController(AccountService service)
        {
            _Service = service;
        }

        public IActionResult AELogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DoLogin(string account, string password, int type)
        {
            var user = _Service.GetUser(account, password);
            if (user == null || user.RoleId != type)
            {
                return Json(new ResponseModel(false, 0, 0));
            }


            return Json(new ResponseModel(true, 0, 0));
        }
    }
}
