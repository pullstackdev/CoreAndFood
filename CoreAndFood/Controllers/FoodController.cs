using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        Context context = new Context(); //db erişim
        FoodRepository foodRepository = new FoodRepository(); //instance alınmalı ki içindeki metodlar çağırıla/kullanılabilsin
        public IActionResult Index(int page=1)
        {
            return View(foodRepository.EntityList("Category").ToPagedList(page,10)); //bu tablo include edilmeli, genericrepoda bu ayrı 1 metodla tanımlandı, parametre alan include içeren metoddur
            //ToPagedList(1,3) 1.değerden başla 3 değer getir
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

        public IActionResult UpdateFood(int id)
        {
            var food = foodRepository.GetEntity(id);
            //category dropdownunu doldurmak için
            List<SelectListItem> categories = (from x in context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.categories = categories;//ile gönderdik categorileri dropdownda alacağız
            return View(food);
        }
        [HttpPost]
        public IActionResult UpdateFood(Food food)
        {
            foodRepository.UpdateEntity(food); //savechanges zaten CategoryRepositoryde mevcut
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