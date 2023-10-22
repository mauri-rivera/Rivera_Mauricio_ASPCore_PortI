using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PortafolioI.Controllers
{
    public class HomeController
    {
        [HttpGet("")]    
        public string Index()
        {
            return "This is my Index!";
        }

        [HttpGet("proyects")]
        public string Proyect()
        {
            return "These are my proyects";
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact!";
        }
    }
}