using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization; //for AllowAnonymous
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFood.Controllers
{
    public class LoginController : Controller
    {
        Context context = new Context();

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        //login olana buradan yetki verilecek, authenticate olacak
        public async Task<IActionResult> Index(Admin admin)
        {
            var userInfos = context.Admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);
            if (userInfos != null) //kulanıcı kayıtlı ise
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, admin.UserName) //atadık
                };
                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Category"); //giriş yapabileni categorye gönder
            }
            return View(); //yapamayan tekrar burada
        }

        public async Task<IActionResult> Logout()
        {
            //bu cookie'yi signout yapıyoruz
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
    }
}