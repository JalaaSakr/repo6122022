using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogLastApp.Data
{

    public class Category
    {

        [Key] public int Category_ID { get; set; }


        [Required]
        [MinLength(2, ErrorMessage = "Please enter category name")]
        public string? Category_Name { get; set; } = "";
    }
}
