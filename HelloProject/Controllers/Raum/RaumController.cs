using HelloProject.Domain;
using HelloProject.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RaumController : Controller
    {
        [HttpPost ]
        public ActionResult<string> Index(Raum raum)
        {
            return "Hello World!";
        }
    }
}
