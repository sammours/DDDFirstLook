using DDDFirstLook.Domain.Customers;
using DDDFirstLook.Domain.Primitives;
using DDDFirstLook.Domain.Products;
using DDDFirstLook.WebMvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDFirstLook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            var customer = new Customer(new FirstName("Samy"), LastNameFactory.Create("Sammour"));

            var product = new Product("Product 2");
            var postalCode = PostalCode.Create("12345");
            product.AddAddress("Str2", postalCode, "Jeddah", "Saudi");
            Console.WriteLine($"Postal code value = {postalCode}");
            Console.WriteLine($"Product value = {product}");
            this.productRepository.Insert(product);
            return new List<Product>() { product};
        }
    }
}
