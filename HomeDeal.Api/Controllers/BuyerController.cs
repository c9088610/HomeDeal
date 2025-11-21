using HomeDeal.Core.Entities;
using HomeDeal.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeDeal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyerController : ControllerBase
    {
        private readonly BuyerService _buyerService;
        
        public BuyerController(BuyerService buyerService)
        {
            _buyerService= buyerService;

        }


        // GET: api/<BuyerController>
        [HttpGet]
        public IEnumerable<Buyer> Get()
        {
            return _buyerService.GetAll();
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
