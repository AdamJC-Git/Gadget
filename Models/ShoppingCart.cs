using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GadgetCompany.Models
{
    public class ShoppingCart
    {
        //basic shopping cart model
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int Count { get; set; }
        public double TotalValue { get; set; }

        //Add the customer user Id so we can save the shopping cart to database so if user leaves the site we 
        //can still save their shopping cart items for when they return. Other option is possibly to save into 
        //session variable but this will only persist for the current session.

        //public int ApplicationUserId { get; set; }
        //[ForeignKey("ApplicationUserId")]
        //public IdentityApplicationUser ApplicationUser { get; set; }
    }
}
