using CoreAndFood.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Repositories
{
    //5 temel crud işlemlerini her tablo/class için tekrar tekrar yazmaya gerek bırakmadan buradan tek seferde iskelet oluşturulacak
    public class GenericRepository<T> where T:class, new() //T class olmalı şartı getirildi ve new barındırabilmeli. kalıtım ile gelecek t yeribe parametreler(classlar)
    {
        Context context = new Context(); //for db erişim

        public List<T> EntityList()
        {
            return context.Set<T>().ToList(); //SET metodu ile dbye giden classı gönderecek ayarlayacak
        }

        public void AddEntity(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void DeleteEntity(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public void UpdateEntity(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }

        public T GetEntity(int id)
        {
           return context.Set<T>().Find(id);
        }

        public List<T> EntityList(string prm) //include gerektiren tablolarda bu metod kullanılsın, food için
        {
            return context.Set<T>().Include(prm).ToList();
        }
    }
}
