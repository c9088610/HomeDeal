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
        private readonly DataContext _Context;
        public BuyerController(DataContext context)
        {
            _Context = context;
        }
             
        // GET: api/<BuyerController>
        [HttpGet]
        public List<Buyer> Get()
        {
            return _Context.Buyer;
        }

        // GET api/<BuyerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Buyer foundBuyer = null;
            foreach (var Buy in _Context.Buyer) { 
                if (Buy.BuyerId == id)
                {
                    foundBuyer = Buy;
                    break;
                }
        }
            if (foundBuyer == null)
            {
                return NotFound($"Buyer with Id {id} not found");
            }

            return Ok(foundBuyer);
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
