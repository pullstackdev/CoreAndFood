using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFood.Controllers
{
    public class DefaultController : Controller //burası vitrin için, herkese açık
    {
        [AllowAnonymous] //burasi vitrin sayfası herkese açık olan sayfa olduğundan bunu kullan
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous] //burasi vitrin sayfası herkese açık olan sayfa olduğundan bunu kullan
        public IActionResult CategoryDetails(int id)
        {
            ViewBag.id = id;
            return View();
        }
        
    }
}