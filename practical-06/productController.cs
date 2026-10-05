using System.Collections.Generic;
using System.Web.Mvc;
using practical_06_.NET.Models;

namespace practical_06_.NET.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Price = 55000,
                    Category = "Electronics"
                },

                new Product
                {
                    Id = 2,
                    Name = "Mouse",
                    Price = 800,
                    Category = "Accessories"
                },

                new Product
                {
                    Id = 3,
                    Name = "Keyboard",
                    Price = 1500,
                    Category = "Accessories"
                },

                new Product
                {
                    Id = 4,
                    Name = "Headphones",
                    Price = 2500,
                    Category = "Audio"
                }
            };

            return View(products);
        }
    }
}
