using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShoppingAPI.Models;

namespace ShoppingAPI.Controllers
{
    [Route("products/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        Product[] products = new Product[]
        {
            new Product {ProductID = 1, Name = "Samsung S10", Category = "Mobile Phones", Price = 3000},
            new Product {ProductID = 2, Name = "Samsung S10", Category = "Mobile Phones", Price = 2999.99M},
            new Product {ProductID = 3, Name = "Samsung S10", Category = "Mobile Phones", Price = 2999},
            new Product {ProductID = 4, Name = "Samsung S10", Category = "Mobile Phones", Price = 3200}
        };

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }
    }
}