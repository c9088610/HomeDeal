using HomeDeal.entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeDeal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private List<Seller> sellers = new List<Seller>
        {
            new Seller{SellerId=100,FullName="Ben natan",Phone="0586621145",Email="ben@gmail.com"},
            new Seller{SellerId=200,FullName="David shir",Phone="0546665520",Email="david@gmail.com"},
            new Seller{SellerId=300,FullName="yael ram",Phone="0521159963",Email="yaelram@gmail.com"}
        };





        // GET: api/<SellerController>
        [HttpGet]
        public List<Seller> Get()
        {
            return sellers;
        }

        // GET api/<SellerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SellerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SellerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SellerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
