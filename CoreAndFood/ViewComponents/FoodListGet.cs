using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.ViewComponents
{
    public class FoodListGet : ViewComponent //bu sınıf inherit edilmeli
    {
        //metod olmalı ve bunu projenin istediğin yerinde çağır kullan js deki components gibi
        public IViewComponentResult Invoke()
        {
            FoodRepository foodRepository = new FoodRepository();
            var foodList = foodRepository.EntityList();
            return View(foodList);
        }
        //kullanılcak klasörde Components -> FoodListGet klasörü eklendi ve Default(ilk klasör ismi) htmli eklendi
    }
}
