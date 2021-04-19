using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc; //form viewcomponent inheritance
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.ViewComponents
{
    public class CategoryListGet : ViewComponent //bu sınıf inherit edilmeli
    {
        //metod olmalı ve bunu projenin istediğin yerinde çağır kullan js deki components gibi
        public IViewComponentResult Invoke()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            var categoryList = categoryRepository.EntityList();
            return View(categoryList);
        }
        //kullanılcak klasörde Components -> CategoryListGet klasörü eklendi ve Default(ilk klasör ismi) htmli eklendi
    }
}
