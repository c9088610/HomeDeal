using HomeDeal.entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeDeal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly DataContext _context; 
        public SellerController(DataContext context)
        {
           _context = context;
        }

        public SellerController()
        {
        }




        // GET: api/<SellerController>
        [HttpGet]
        public List<Seller> Get()
        {
            return _context.Seller;
        }

        // GET api/<SellerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {

            Seller foundSellers = null;
            foreach (var sellery in _context.Seller)
            {
                if (sellery.SellerId == id)
                {
                    foundSellers = sellery;
                    break;
                }
            }
            if (foundSellers == null)
            {
                return NotFound($"Sellers with Id {id} not found");
            }

            return Ok(foundSellers);
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
