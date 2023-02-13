using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloProject.Controllers
{
    [ApiController]
    [Route ("api/[controller]")]
    public class HelloController : Controller
    {
        [HttpGet]
        public ActionResult<string> Index()
        {
            return "Hello World!";
        }
    }
}
