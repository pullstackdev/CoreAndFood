using CoreAndFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Repositories
{
    public class FoodRepository: GenericRepository<Food> //kalıtım ile generice gidilip T yerine gelecek Food parametreside gitti
    {


        //5 temel crud işlemini burada metod olarak tanımlayacağız

        //artık gerek yok çünkü generic respository eklendi********************* artık sadece buraya özel metodlar eklenebilir

        //Context context = new Context();

        //public List<Food> FoodList()
        //{
        //    return context.Foods.ToList();
        //}

        //public void AddFood(Food food)
        //{
        //    context.Foods.Add(food);
        //    context.SaveChanges();
        //}

        //public void DeleteFood(Food food)
        //{
        //    context.Foods.Remove(food);
        //    context.SaveChanges();
        //}

        //public void UpdateFood(Food food)
        //{
        //    context.Foods.Update(food);
        //    context.SaveChanges();
        //}

        //public void GetFood(int id)
        //{
        //    context.Foods.Find(id);
        //}
    }
}
