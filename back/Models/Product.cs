using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarBon.Models
{
    [Table("Product")]
    public class Product
    {
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public long price { get; set; }
        [Required]
        public string image { get; set; }
    }
}
