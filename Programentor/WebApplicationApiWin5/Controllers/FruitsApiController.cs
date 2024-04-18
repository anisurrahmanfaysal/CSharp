using Microsoft.AspNetCore.Mvc;

namespace WebApplicationApiWin5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public List<string> Fruits = new List<string>(){
            "Orange",
            "Cherry",
            "Mango",
            "Banana"
        };

        [HttpGet]
        public List<string> GetFruits(){
            return Fruits;
        }

        [HttpGet("{id}")]
        public string GetFruitsById(int id){
            return Fruits.ElementAt(id);
        }
    }
}
