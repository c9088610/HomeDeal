using HomeDeal.entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeDeal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyerController : ControllerBase
    {
        private List<Buyer> buyers = new List<Buyer>
        {
            new Buyer {BuyerId=1,FullName="Avrahm Levi",Phone="0527676152",Email="avram@gmail.com",MaxBudget=2500000,RegistrationDate=DateTime.Parse("05/10/2025")},
            new Buyer {BuyerId=2,FullName="shay cohen",Phone="0527777715",Email="shay@gmail.com",MaxBudget=3000000,RegistrationDate=DateTime.Parse("01/07/2025")},
            new Buyer {BuyerId=3,FullName="shira marom",Phone="0545483241",Email="shira@gmail.com",MaxBudget=2000000,RegistrationDate=DateTime.Parse("12/12/2025")},
            new Buyer {BuyerId=4,FullName="sara danan",Phone="0579982154",Email="sara@gmail.com",MaxBudget=1900000,RegistrationDate=DateTime.Parse("16/08/2025")}
        };

             
        // GET: api/<BuyerController>
        [HttpGet]
        public List<Buyer> Get()
        {
            return buyers;
        }
        
        // GET api/<BuyerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BuyerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BuyerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BuyerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
