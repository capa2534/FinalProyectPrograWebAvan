using Examen.DataAccess.Data;
using Examen.DataAccess.Repository;
using Examen.DataAccess.Repository.UnitOfWork;
using Examen.Models.DataModels;
using Lec10.Application;
using Lec10.Application.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AuthorizeAttribute = Microsoft.AspNetCore.Authorization.AuthorizeAttribute;

namespace Lec12.WebApi.Controllers
{
    [ApiController]
    [Route("api/autos")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class AutosApiController : ControllerBase
    {
        public AutosApiController(IJwtManager jwtManager)
        {
            _jwtManager = jwtManager;
        }

        readonly IJwtManager _jwtManager;

        [HttpGet]
        [Route("test")]
        public IActionResult TEST()
        {

            List<Auto> autos = new List<Auto>();


            DbContext context = new DbContext("");
            
            
            using (context dc = new DbContext())
            {
              
                employeeList = dc.Employees.OrderBy(a => a.Name).ToList();
               


            return new JsonResult(autos);
        }




        [HttpPost]
        [Route("/api/authenticate")]
        [AllowAnonymous]
        public IActionResult Authenticate(JwtUser input)
        {
            var token = _jwtManager.Authenticate(input);

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }
    }
}
