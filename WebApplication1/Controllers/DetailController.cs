using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/xml")]
    public class DetailController : Controller
    {
        Detail[] details = new Detail[]
        {
                new Detail{id = 1,name="John Johansen", Address="54 Oak", salary=50000},
                new Detail{id = 2,name="Steve Smith",Address="84 Elm",salary= 40000},
                new Detail {id = 3,name="Tyler Thompson",Address="26 Maple",salary=480000}
        };

        // GET: api/detail
        [HttpGet]
        public IEnumerable<Detail> Get()
        {
            return details;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
