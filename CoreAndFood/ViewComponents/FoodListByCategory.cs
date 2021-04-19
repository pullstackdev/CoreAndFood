using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.ViewComponents
{
    public class FoodListByCategory: ViewComponent
    {
        //metod olmalı ve bunu projenin istediğin yerinde çağır kullan js deki components gibi
        public IViewComponentResult Invoke(int id)
        {
            //controllerdan viewbag ile id gönderdik, int id aynı isimli id ile awaitde çağırdık bunu
            FoodRepository foodRepository = new FoodRepository();
            var foodList = foodRepository.List(x=>x.CategoryID==id); //genericrepoya gönderilen "filter" alanı
            return View(foodList);
        }
        //views da klasör ve view oluşturuldu default isminde
    }
}
