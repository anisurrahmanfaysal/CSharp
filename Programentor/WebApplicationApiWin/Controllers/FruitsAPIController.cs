using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationApiWin.Controllers
{
    [ApiController]                     // Differance between controller and apiController
    [Route("api/[controller]")]         //url for this api.
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
        public List<string> GetFruits(){
            return fruits;
        }
    }
}