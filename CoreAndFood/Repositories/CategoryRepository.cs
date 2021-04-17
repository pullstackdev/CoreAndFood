using CoreAndFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Repositories
{
    public class CategoryRepository : GenericRepository<Category> //kalıtım ile generice gidilip T yerine gelecek Category parametreside gitti
    {


        //5 temel crud işlemini burada metod olarak tanımlayacağız

        //artık gerek yok çünkü generic respository eklendi************************ artık sadece buraya özel metodlar eklenebilir

        //Context context = new Context(); //for db erişim

        //public List<Category> CategoryList()
        //{
        //    return context.Categories.ToList();
        //}

        //public void AddCategory(Category category)
        //{
        //    context.Categories.Add(category);
        //    context.SaveChanges();
        //} 

        //public void DeleteCategory(Category category)
        //{
        //    context.Categories.Remove(category);
        //    context.SaveChanges();
        //}

        //public void UpdateCategory(Category category)
        //{
        //    context.Categories.Update(category);
        //    context.SaveChanges();
        //}

        //public void GetCategory(int id)
        //{
        //    context.Categories.Find(id);
        //}




    }
}
