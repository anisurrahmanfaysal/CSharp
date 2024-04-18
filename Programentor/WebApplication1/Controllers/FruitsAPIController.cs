using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FruitsAPIController : ControllerBase
{
    // Temp database
    public List<string> fruits = new List<string>(){        // Learn List
        "Apple",
        "Bannana",
        "Mango",
        "Cherry",
        "Grapes"
    };

    // Action method from apiController
    [HttpGet]
    public List<string> GetFruits()
    {
        return fruits;
    }

    // Action method from apiController with parameter.
    [HttpGet("{id}")]
    public string GetFruitsByIndex(int id)
    {
        return fruits.ElementAt(id);
    }
}