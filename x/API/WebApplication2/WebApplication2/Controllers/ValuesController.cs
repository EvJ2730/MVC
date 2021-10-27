using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    private BookDbContext _dbContext;

    public ValuesController()
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("")]
        public ActionResult Index()
        {
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
