using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers.General
{
    public interface ITokenBuild
    {
        TokenResult CreateToken(IConfiguration configuration, string userName, string email);
        void CreateCacheTokenSid(string guidSID);
        bool IsCacheTokenSidExists(string guidSID);
        bool SecurityTokenVerification(JwtSecurityToken accessToken);
    }
}
