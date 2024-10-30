using GadgetCompany.DataAccess;
using GadgetCompany.Models;
using GadgetCompany.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GadgetCompany.Areas.Customer.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DashboardController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(ProductFilter filter)
        {
            var productVm = new ProductVM();

            //will just display Products from this page as it is the default landing page at the moment
            var products = _db.Products.Include(x => x.ProductType);

            if (!string.IsNullOrWhiteSpace(filter.ProductName))
            {
                products = products.Where(x => x.Name.Contains(filter.ProductName)).Include(y => y.ProductType);
            }
            productVm.Products = products;
            
            return View(productVm);
        }
    }
}
