using Microsoft.AspNetCore.Mvc;
using HomeDeal.Core.Entities;
using HomeDeal.Core.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeDeal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyerController : ControllerBase
    {
        private readonly IBuyerService _buyerService;
        public BuyerController(IBuyerService buyerService)
        {
            _buyerService = buyerService;
        }


        // GET: api/<BuyerController>
        [HttpGet]
        public IEnumerable<Buyer> Get()
        {
            return _buyerService.GetList();
        }

        // GET api/<BuyerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {



            Buyer foundBuyer = _buyerService.GetById(id);

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
