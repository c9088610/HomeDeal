using HomeDeal.entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeDeal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly DataContext _Context;
        public PropertyController(DataContext context)
        {
            _Context = context;
        }



        // GET: api/<PropertyController>
        [HttpGet]
        public List<Property> Get()
        {
            return _Context.Property;
        }

        // GET api/<PropertyController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {

            Property foundProperty = null;
            foreach (var prop in _Context.Property)
            {
                if (prop.PropertyId == id)
                {
                    foundProperty = prop;
                    break;
                }
            }
            if (foundProperty == null)
            {
                return NotFound($"Property with Id {id} not found");
            }

            return Ok(foundProperty);
        }


        // POST api/<PropertyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PropertyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PropertyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
