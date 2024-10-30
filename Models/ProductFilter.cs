using System.ComponentModel.DataAnnotations;

namespace GadgetCompany.Models
{
    public class ProductFilter
    {
        //can add multiple fields here on which to filter/search the products table. I am just entering Product Name
        [Display(Name = "Search Product Name")]
        public string ProductName { get; set; }

    }
}
