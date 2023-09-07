using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CepaApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        public HomeController()
        {

        }  

        [HttpGet]
        public string Get()
        {
            return "Exemplo de get";
        }
        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put = {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de delete = {id}";
        }
    }
}
