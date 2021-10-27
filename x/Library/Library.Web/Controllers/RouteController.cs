using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Controllers
{
    [Route("knigi")]
    public class RouteController : Controller
    {
        [Route("glavna-strana")]
        public IActionResult Index()
        {
            return new JsonResult(new { Message = "Test Routing" });
        }
    }
}
