using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    { 
        //[HttpGet("api/cities")]
        [HttpGet("api/cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(new List<object>()
            {
                new { id=1, Name="New York City" },
                new { id=2, Name="Antwerp" }
            });

            //return new JsonResult(CitiesDataStore.Current.Cities);

            //var temp = new JsonResult(CitiesDataStore.Current.Cities);
            //temp.StatusCode = 200;
            //return temp;
        }

        [HttpGet("api/cities/{id}")]
        public JsonResult GetCity(int id)
        {
            return new JsonResult(
                CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));

        }
    }
}
