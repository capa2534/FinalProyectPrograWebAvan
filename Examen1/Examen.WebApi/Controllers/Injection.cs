using Lec10.Application.Configurations;
using Lec10.Application.Contracts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec10.Application
{
    public static class Injection
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            JwtConfiguration jwtConfiguration = configuration.GetSection("JwtConfiguration").Get<JwtConfiguration>();


     
            services.AddSingleton<IJwtManager, JwtManager>();


            services.AddAuthentication(
                options => {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;

                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }
                ).AddJwtBearer(
                    options =>
                    {
                        var secretkey = Encoding.UTF8.GetBytes(jwtConfiguration.Signinkey);
                        options.SaveToken = true;
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuer = false,
                            ValidateAudience = false,
                            ValidateLifetime = true,
                            ValidateIssuerSigningKey = true,
                            ValidIssuer = jwtConfiguration.Issuer,
                            ValidAudience = jwtConfiguration.Audience,
                            IssuerSigningKey = new SymmetricSecurityKey(secretkey)
                        };
                    }
                  );
            return services;
        }
    }
}
