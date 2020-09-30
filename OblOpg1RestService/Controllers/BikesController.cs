using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeLib;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestService.Controllers
{
    [Route("api/localBikes")]
    [ApiController]
    public class BikesController : ControllerBase
    {
        private static List<Bike> _bikes = new List<Bike>()
        {
            new Bike(1, "Red", 29.9, 5),
            new Bike(2, "Green", 36.3, 8),
            new Bike(3, "Red", 43.5, 23),
            new Bike(4, "Yellow", 53.9, 14),
            new Bike(5, "Black", 50.0, 20)
        };

        // GET: api/<BikesController>
        [HttpGet]
        public IEnumerable<Bike> Get()
        {
            return _bikes;
        }

        // GET api/<BikesController>/5
        [HttpGet("{id}")]
        public Bike Get(int id)
        {
            return _bikes.Find(i => i.Id == id);
        }

        // POST api/<BikesController>
        [HttpPost]
        public void Post([FromBody] Bike value)
        {
            _bikes.Add(value);
        }

        // PUT api/<BikesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Bike value)
        {
            Bike bike = Get(id);
            if (bike != null)
            {
                bike.Id = value.Id;
                bike.Color = value.Color;
                bike.Price = value.Price;
                bike.Gear = value.Gear;
            }
        }

        // DELETE api/<BikesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Bike bike = Get(id);
            _bikes.Remove(bike);
        }
    }
}
