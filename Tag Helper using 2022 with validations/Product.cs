using System.ComponentModel.DataAnnotations;

namespace Tag_Helper.Models
{
    public class Product
    {
        public int id { get; set; }

        [Required(ErrorMessage ="Product Name is required")]
        public string? ProductName { get; set; }

        [Required(ErrorMessage ="Price is required")]
        public int Price { get; set; }

        [Required(ErrorMessage ="Description is required")]
        public string? Description { get; set; }
    }
}
