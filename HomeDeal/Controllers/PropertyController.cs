using HomeDeal.Core.Entities;
using HomeDeal.Core.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeDeal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyService _propertyService;
        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }



        // GET: api/<PropertyController>
        [HttpGet]
        public List<Property> Get()
        {
            return _propertyService.GetList();
        }

        // GET api/<PropertyController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {

            Property foundProperty = null;
            foreach (var prop in _propertyService.Property)
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
