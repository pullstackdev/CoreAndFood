using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //data validationlar için
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Name cannot be empty!")] //data validationlar için attributelar kullanılır
        [StringLength(20, ErrorMessage = "Only 4-20 character!", MinimumLength = 4)]
        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
        public bool Status { get; set; }//bu tablonun foodda ilişkili alanı olduğu için silme değil aktif pasif yapalım

        //ilişkiler
        public List<Food> Foods { get; set; } //1->ÇOK
    }
}
