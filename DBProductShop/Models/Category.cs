using System.ComponentModel.DataAnnotations;

namespace DBProductShop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }


        [Required(ErrorMessage = "Please enter category name")]
        public string Name { get; set; }
    }
}
