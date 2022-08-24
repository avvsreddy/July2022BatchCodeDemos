using System.ComponentModel.DataAnnotations;

namespace ProductsCatalogApp.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public Catagory Catagory { get; set; }
    }
    public class Catagory
    {
        public int CatagoryID { get; set; }
        public string Name { get; set; }
    }
}
