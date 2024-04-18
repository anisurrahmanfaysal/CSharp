using Microsoft.AspNetCore.Mvc;

namespace WebApplicationApiWin4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitsApiController : ControllerBase
    {
        public List<string> Fruits = new List<string>(){
            "Banana",
            "Cherry",
            "Apple",
            "Mango"
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
