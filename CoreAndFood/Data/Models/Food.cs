using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Food
    {
        public int FoodID { get; set; }
        [Required(ErrorMessage = "Name cannot be empty!")] //data validationlar için attributelar kullanılır
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int Stock { get; set; }

        //ilişkiler
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; } //1-1 ilişki
    }
}
