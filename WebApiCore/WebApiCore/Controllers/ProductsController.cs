using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCore.Models;

namespace WebApiCore.Controllers
{
    //[Produces("application/json")]
    [Route("api/Products/")]
    public class ProductsController : Controller
    {

        // GET: api/Products
        [HttpGet]
        public List<Product> Get()
        {
            List<Product> prodList = new List<Product>();

            prodList.Add(new Product()
            {
                productId = 1,
                productName = "Leaf Rake",
                productCode = "GDN-0011",
                releaseDate = new DateTime(2017, 10, 18),
                description = "Leaf rake with 48-inch wooden handle.",
                price = 19.29M,
                starRating = 3.5M
            });
            prodList.Add(new Product()
            {
                productId = 2,
                productName = "Garden Cart",
                productCode = "GDN-0023",
                releaseDate = new DateTime(2016, 3, 18),
                description = "15 gallon capacity rolling garden cart",
                price = 32.99M,
                starRating = 4.2M
            });
            prodList.Add(new Product()
            {
                productId = 5,
                productName = "Hammer",
                productCode = "TBX-0048",
                releaseDate = new DateTime(2016, 5, 21),
                description = "Curved claw steel hammer",
                price = 8.9M,
                starRating = 4.8M
            });
            prodList.Add(new Product()
            {
                productId = 8,
                productName = "Saw",
                productCode = "TBX-0022",
                releaseDate = new DateTime(2016, 5, 15),
                description = "15-inch steel blade hand saw",
                price = 11.55M,
                starRating = 3.7M
            });
            prodList.Add(new Product()
            {
                productId = 10,
                productName = "Video Game Controller",
                productCode = "GMG-0042",
                releaseDate = new DateTime(2015, 10, 15),
                description = "Standard two-button video game controller",
                price = 35.95m,
                starRating = 4.6m
            });

            return prodList;
        }

        // GET: api/Products/5
        [HttpGet("getproduct/{id}")]
        public List<Product> Get(int id)
        {
            List<Product> productList = new List<Product>();

            productList.Add(new Product()
            {
                productId = 2,
                productName = "Garden Cart",
                productCode = "GDN-0023",
                releaseDate = new DateTime(2015, 10, 15),
                description = "15 gallon capacity rolling garden cart",
                price = 32.99M,
                starRating = 4.2M
            });

            return productList;
        }

        // POST: api/Products
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
