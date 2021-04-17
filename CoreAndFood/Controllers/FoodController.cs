using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        Context context = new Context(); //db erişim
        FoodRepository foodRepository = new FoodRepository(); //instance alınmalı ki içindeki metodlar çağırıla/kullanılabilsin
        public IActionResult Index()
        {
            return View(foodRepository.EntityList("Category")); //bu tablo include edilmeli, genericrepoda bu ayrı 1 metodla tanımlandı
        }
        public IActionResult AddFood()
        {
            //category dropdownunu doldurmak için
            List<SelectListItem> categories = (from x in context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.categories = categories;//ile gönderdik categorileri dropdownda alacağız
            return View();
        }
        [HttpPost]
        public IActionResult AddFood(Food food)
        {
            foodRepository.AddEntity(food); //savechanges zaten CategoryRepositoryde mevcut
            return RedirectToAction("Index");
        }

        public IActionResult DeleteFood(int id) //id olmalı ismi, startupda optional ismi id
        {
            //var food = foodRepository.GetEntity(id); çalışırdı ancak repodan return yapmıyor ondan dolayı 2.yöntemi kullan
            foodRepository.DeleteEntity(new Food { FoodID = id }); //new'leyerek bu id'li food modeli alınmış oluyor
            return RedirectToAction("Index");
        }
    }
}