using System.ComponentModel.DataAnnotations.Schema;

namespace PastaciOnlineMVC.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName  { get; set; }
        public string  ProductComment { get; set; }
        public int Category { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public double Price { get; set; }
        public string ImagePath { get; set; }

    }
}
