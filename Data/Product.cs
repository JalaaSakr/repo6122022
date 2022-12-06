using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogLastApp.Data
{
    //[Table("Products_tbl")]
    public class Product
    {

        [Key] public int Product_ID { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Product name must be 5 chars at least ")]
        public string Product_Name { get; set; } = "";

        [Required]
        public int Product_CategoryID { get; set; }


    }
}
