﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFood.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository(); //instance alınmalı ki içindeki metodlar çağırıla/kullanılabilsin
        public IActionResult Index(string p) //arama için string p koyuldu
        {
            if (!string.IsNullOrEmpty(p)) 
            {
                return View(categoryRepository.List(x => x.CategoryName.Contains(p))); //aranan string değeri dön
                //ayrıca .ToList() zaten repoda var
            }

            return View(categoryRepository.EntityList());
        }
        //default olarak httpget
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            if (!ModelState.IsValid) //modele yazılan required vs. attribute'ün koontrolü buradan yapılır
            {
                return View("AddCategory");
            }
            categoryRepository.AddEntity(category); //savechanges zaten CategoryRepositoryde mevcut
            return RedirectToAction("Index");
        }

        public IActionResult UpdateCategory(int id)
        {
            var category = categoryRepository.GetEntity(id); //fooddelete de return olmadığı için repo 2.yöntem kullanıldı ancak buradaki return yapıldı
            return View(category); //update edilecek category'nin verilerini view'a gönderdik orda görünsün diye
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            if (!ModelState.IsValid) //modele yazılan required vs. attribute'ün koontrolü buradan yapılır
            {
                return View("UpdateCategory");
            }
            categoryRepository.UpdateEntity(category); //savechanges zaten CategoryRepositoryde mevcut
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id) //foodda category id olduğu için category silme farklı, ama category de foodid alanı yok ondan food standart silme işlemi
        {
            var category = categoryRepository.GetEntity(id);
            category.Status = false;
            categoryRepository.UpdateEntity(category);
            return RedirectToAction("Index");
        }
    }
}