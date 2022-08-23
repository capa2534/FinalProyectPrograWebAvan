using Lec10.Application.Configurations;
using Lec10.Application.Contracts;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lec10.Application
{
    public class JwtManager : IJwtManager
    {
       public JwtManager(IOptions<JwtConfiguration> options) {
            _configuration = options.Value;
        }


        readonly JwtConfiguration _configuration;

        public JwtToken Authenticate(JwtUser input) {
            var handler = new JwtSecurityTokenHandler();
            var secretKey = Encoding.UTF8.GetBytes("(nWeaEv8E=sZiIpJU-@d=[a,TPmAfo(3");

            var date = DateTime.UtcNow;
       


            var descriptor = new SecurityTokenDescriptor
            {
                Expires = date.AddMinutes(10),
                NotBefore = date,
                Subject = new ClaimsIdentity
                                            (new[] { new Claim(ClaimTypes.Name, input.UserName) }),
             
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha256Signature)
            };
                var token = handler.CreateToken(descriptor);
            return new JwtToken { Token = handler.WriteToken(token) };

}

        public bool IsTokenValid(string token, out SecurityToken authorizedToken)
        {
            authorizedToken = null;
            var secretkey = Encoding.UTF8.GetBytes(_configuration.Signinkey);
            var handler = new JwtSecurityTokenHandler();
            try
            {
                handler.ValidateToken
                    (
                    token,
                    new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = _configuration.Issuer,
                        ValidAudience = _configuration.Audience,
                        IssuerSigningKey = new SymmetricSecurityKey(secretkey)
                    },
                    out SecurityToken validatedToken
                    );

                authorizedToken = validatedToken;
                if (authorizedToken.ValidTo < DateTime.UtcNow)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }    
    }
}
