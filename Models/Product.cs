using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace kautilyaminterviewdemo.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        [Range(1,500000,ErrorMessage="Price greater  than 0")]
         public int Price { get; set; }
        [Required]
        public string  Productcolor { get; set; }
        [Required]
        public string ProductDescription { get; set; }

        [Required]
        public int DesignCode { get; set; }
    }
}
