using System.ComponentModel.DataAnnotations;

namespace GadgetCompany.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
