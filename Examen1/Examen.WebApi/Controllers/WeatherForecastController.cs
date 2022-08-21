using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Lec10.WebApi.Controllers
{
    [ApiController]
    [Route("api/weather")]
   // [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = "Bearer")]

    public class WeatherForecastController : ControllerBase
    {
      
        [HttpGet]
        [Route("getmyip")]
        public IActionResult GetMyIp()
        {
            return new JsonResult("TEST");
        }

    }
}
