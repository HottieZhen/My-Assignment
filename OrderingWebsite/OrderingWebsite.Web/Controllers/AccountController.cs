using System;
using System.Linq;
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

        public IActionResult Denied()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult RestPwd()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DoLogin(string account, string password, int type)
        {
            var user = _Service.GetUser(account, Encryp.MD5Encrypt(password));
            if (user == null || user.RoleId != type)
            {
                return Json(new ResponseModel(false, 0, 0));
            }

            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
            identity.AddClaim(new Claim(ClaimTypes.Name, account));
            identity.AddClaim(new Claim("UserId", user.Id.ToString()));
            identity.AddClaim(new Claim(ClaimTypes.Role, user.RoleId.ToString()));
            await HttpContext.SignInAsync(new ClaimsPrincipal(identity));

            return Json(new ResponseModel(true, 0, 0));
        }

        public async Task<IActionResult> AELogout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Account/AELogin");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Account/Login");
        }

        public async Task<IActionResult> RetPwd(string oldPassword, string newPassword)
        {
            var userIdStr = User.Claims.SingleOrDefault(s => s.Type == "UserId").Value;
            int.TryParse(userIdStr, out int userId);

            var result = await _Service.ResetPwd(userId, Encryp.MD5Encrypt(oldPassword), Encryp.MD5Encrypt(newPassword));
            return Json(new ResponseModel(result, 0, 0));
        }

        [HttpPost]
        public IActionResult Register(string username, string password, string address, string phone)
        {
            var result = _Service.Register(username.Trim(), Encryp.MD5Encrypt(password), address, phone);
            return Json(new ResponseModel(result, 0, 0));
        }
    }
}
