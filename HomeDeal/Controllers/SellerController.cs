using HomeDeal.Core.Entities;
using HomeDeal.Core.Service;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeDeal.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly ISellerService _sellerService; 
        public SellerController(ISellerService SellerService)
        {
            _sellerService = SellerService;
        }

     
        // GET: api/<SellerController>
        [HttpGet]
        public List<Seller> Get()
        {
            return _sellerService.GetList();
        }

        // GET api/<SellerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {

            Seller foundSellers = _sellerService.GetById(id); 
          
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
