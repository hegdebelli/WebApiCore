using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCore.Controllers
{
    //[Produces("application/json")]
    [Route("api/Authours/")]
    public class AuthoursController : Controller
    {
        // GET: api/Authours
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Author 1", "Author 2", "Author 3" };
        }

        // GET: api/Authours/5
        [HttpGet("getauthour/{id}")]
        public string Get(int id)
        {
            return "Author";
        }

        // POST: api/Authours
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Authours/5
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
