using Lec10.Application.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec10.Application
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public AuthorizeAttribute(IJwtManager jwtManager)
        {
            _jwtManager = jwtManager;
        }
        readonly IJwtManager _jwtManager;
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
            if (allowAnonymous)
            {
                return;
            }


            if (JwtMiddleware.TryGetToken(context.HttpContext.Request, out string bearer))

                if (_jwtManager.IsTokenValid(bearer, out SecurityToken authorizedToken))
                {

                    context.Result = new JsonResult(new { message = "200 0K" })
                    { StatusCode = StatusCodes.Status200OK };
                }
                else
                {
                    context.Result = new JsonResult(new { message = "Unauthorized" })
                    { StatusCode = StatusCodes.Status401Unauthorized };
                }

        }
    }

}
