using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace Lec10.Application.Contracts
{
    public interface IJwtManager
    {
        JwtToken Authenticate(JwtUser input);

        bool IsTokenValid(string token, out SecurityToken authorizedToken);
    }
}
