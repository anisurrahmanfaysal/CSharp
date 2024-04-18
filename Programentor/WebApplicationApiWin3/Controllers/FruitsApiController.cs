using Microsoft.AspNetCore.Mvc;

namespace WebApplicationApiWin3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitsApiController : ControllerBase
    {
        
        public List<string> Fruits = new List<string>(){
            "Mango",
            "Apple",
            "Banana",
            "cherry",
            "Orange"
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
