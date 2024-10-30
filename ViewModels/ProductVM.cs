using GadgetCompany.Models;

namespace GadgetCompany.ViewModels
{
    public class ProductVM
    {
        public IEnumerable<Product> Products { get; set; }
        public ProductFilter Filter { get; set; }
    }
}
