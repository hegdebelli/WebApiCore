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
        public Product Get()
        {
            return new Product
            {
                productId = 1,
                productName = "Leaf Rake",
                productCode = "GDN-0011",
                releaseDate = new DateTime(),
                description = "Leaf rake with 48-inch wooden handle.",
                price = 19.29M,
                starRating = 3.5M
            };
        }

        // GET: api/Products/5
        [HttpGet("getproduct/{id}")]
        public string Get(int id)
        {
            return "value";
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
