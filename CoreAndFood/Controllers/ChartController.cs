using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Data;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFood.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index() //for google pie chart
        {
            return View();
        }

        public IActionResult Index2() //for google column chart
        {
            return View();
        }

        public IActionResult VisualizeProductResult()
        {
            return Json(ProList()); //Prolistteki listeyi json olarak döndürdük
        }
        public List<ChartC> ProList()
        {
            //static liste oluşturduk
            List<ChartC> cs = new List<ChartC>()
            {
                new ChartC(){proname="computer", stock=150},
                new ChartC(){proname="lcd", stock=75},
                new ChartC(){proname="usd", stock=220},
            };
            return cs;
        }

        public IActionResult Index3()
        {
            return View();
        }

        public IActionResult VisualizeProductResult2()
        {
            return Json(FoodList());
        }

        public List<ChartC2> FoodList()
        {
            List<ChartC2> cs2 = new List<ChartC2>();

            //cs2 modelindeki proplara db den atamalar yapılacak**önemli
            using (var context = new Context()) //contexti burada aç kullan
            {
                cs2 = context.Foods.Select(x => new ChartC2
                {
                    foodname = x.Name,
                    stock = x.Stock
                }).ToList();
            }
            return cs2;
        }

        public IActionResult Statistics()
        {
            //istatistikleri doldurmak için linq sorgular yazılacak

            Context context = new Context();

            var totalFoodCount = context.Foods.Count();
            ViewBag.totalFoodCount = totalFoodCount;

            var totalCategoryCount = context.Categories.Count();
            ViewBag.totalCategoryCount = totalCategoryCount;

            var fruitCount = context.Foods.Where(x => x.CategoryID == 1).Count();
            ViewBag.fruitCount = fruitCount;

            var vegetableCount = context.Foods.Where(x => x.CategoryID == 2).Count();
            ViewBag.vegetableCount = vegetableCount;

            //farklı bir yöntem, isimden id yi bulup koyduk
            var legumesCount = context.Foods.Where(x => x.CategoryID == context.Categories.Where(x=>x.CategoryName=="Legumes").Select(x=>x.CategoryID).FirstOrDefault()).Count();
            ViewBag.legumesCount = legumesCount;

            var foodStockCount = context.Foods.Sum(x => x.Stock);
            ViewBag.foodStockCount = foodStockCount;

            var foodLargestStock= context.Foods.OrderByDescending(x=>x.Stock).Select(x=>x.Name).FirstOrDefault();
            ViewBag.foodLargestStock = foodLargestStock;

            //var foodAveragePrice = context.Foods.Sum(x => x.Price) / context.Foods.Count();
            var foodAveragePrice = context.Foods.Average(x => x.Price).ToString("0.00"); // , den sonra 2 haneli formatlama
            ViewBag.foodAveragePrice = foodAveragePrice;

            var fruitStockCount = context.Foods.Where(x => x.CategoryID == context.Categories.Where(x => x.CategoryName == "Fruit").Select(x => x.CategoryID).FirstOrDefault()).Sum(x => x.Stock);
            ViewBag.fruitStockCount = fruitStockCount;

            var vegetableStockCount = context.Foods.Where(x => x.CategoryID == context.Categories.Where(x => x.CategoryName == "Vegetables").Select(x => x.CategoryID).FirstOrDefault()).Sum(x => x.Stock);
            ViewBag.vegetableStockCount = vegetableStockCount;

            var legumeStockCount = context.Foods.Where(x => x.CategoryID == context.Categories.Where(x => x.CategoryName == "Legumes").Select(x => x.CategoryID).FirstOrDefault()).Sum(x => x.Stock);
            ViewBag.legumeStockCount = legumeStockCount;

            var totalBalance = (Convert.ToDecimal(foodAveragePrice) * foodStockCount).ToString("0.00");
            ViewBag.totalBalance = totalBalance;

            return View();
        }

    }
}