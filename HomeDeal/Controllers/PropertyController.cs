using HomeDeal.entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeDeal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private List<Property> properties = new List<Property>
        {
            new Property{PropertyId=1000,Adress="Raby Akiva 48,Beny-Brak",Price=2700000,NumberOfRooms=4.5,IsActiv=false},
            new Property{PropertyId=2000,Adress="Raby yehuda hanasi 56,Petah-tikva",Price=3500000,NumberOfRooms=6.5,IsActiv=true},
            new Property{PropertyId=3000,Adress="wayzman 14,Herzelya",Price=4500000,NumberOfRooms=8,IsActiv=true}
        };



        // GET: api/<PropertyController>
        [HttpGet]
        public List<Property> Get()
        {
            return properties;
        }

        // GET api/<PropertyController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {

            Property foundProperty = null;
            foreach (var prop in properties)
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
