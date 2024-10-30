using GadgetCompany.DataAccess;
using GadgetCompany.Models;
using GadgetCompany.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace GadgetCompany.Areas.Customer.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ShoppingCartController(ApplicationDbContext db)
        {
            _db = db;
        }
        //public IActionResult Index(int productId)
        //{
        //Get all the shopping cart records for a specific system user
        //Run the GetTotalCost method

        //Display users shopping cart


        //return View(cartVm);
        //}

        //Other methods needed

        //Add product - increase the count of the product in shopping cart and run GetTotalCost

        //Minus product - decrease the count of the product in shopping cart and run GetTotalCost

        //Remove product - completely delete the product from user's shopping cart and run GetTotalCost

        //GetTotalCost method to add the cost of the shopping cart and display to user.
    }
}

