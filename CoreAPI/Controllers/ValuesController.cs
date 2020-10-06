using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("GetPublicValues")]
        public IActionResult GetPublicValues()
        {
            return Ok("This is Public endpoint");
        }

        [HttpGet]
        [Route("GetPrivateValues")]
        [Authorize]
        public IActionResult GetPrivateValues()
        {
            return Ok("This is a Private endpoint");
        }
    }
}
