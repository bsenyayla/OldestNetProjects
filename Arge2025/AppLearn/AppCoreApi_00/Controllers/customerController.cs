using AppCoreApi_00.Actions;
using AppCoreApi_00.DataModels;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppCoreApi_00.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class customerController : ControllerBase
    {
        // GET: api/<customerController>
        [HttpGet]
        public ReservationTypeMain Get()
        {
            return new CustomerActionMethods().GetCustomerDetails();
           //return new string[] { "value1", "value2" };
        }

        // GET api/<customerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<customerController>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<customerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<customerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
