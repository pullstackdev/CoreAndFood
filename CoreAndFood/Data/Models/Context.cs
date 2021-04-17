using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-HGL39QT; database=DbCoreFood; integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }//büyük ve çoğul
        public DbSet<Food> Foods { get; set; }

    }
}
