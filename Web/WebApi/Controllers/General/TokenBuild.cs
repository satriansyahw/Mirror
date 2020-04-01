using GenHelper.Cache;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Controllers.General
{
    public class TokenResult
    {
        public string AccessToken { get; set; }
        public string SIDToken { get; set; }
    }
    public class TokenBuild:ITokenBuild
    {
        private readonly MemoryCacher cacher = MemoryCacher.GetInstance;
        private readonly double tokenSIDHourLimit = 48;//2 days
        public TokenBuild()
        {

        }
        private static TokenBuild instance;
        public static TokenBuild GetInstance
        {
            get
            { 
                
                if (instance == null) instance = new TokenBuild();
                return instance;
            }
        }

        public TokenResult CreateToken(IConfiguration configuration,string userName,string email)
        {
            TokenResult result = new TokenResult();
            string tokenKey = configuration.GetSection("APISettings:TokenKey").Value;
            string tokenIssuer = configuration.GetSection("APISettings:TokenIssuer").Value;
            string tokenAudience = configuration.GetSection("APISettings:TokenAudience").Value;
            string tokenAlgo = configuration.GetSection("APISettings:TokenAlgo").Value;
            string tokenSid = Guid.NewGuid().ToString().Replace("-", "");

            /*Bisa Buat def sendiri*/
            DateTime dtExpired = DateTime.Now.AddHours(tokenSIDHourLimit);

            var claims = new[] {
            new Claim(JwtRegisteredClaimNames.UniqueName, userName),
            new Claim(JwtRegisteredClaimNames.Email, email),
            new Claim(JwtRegisteredClaimNames.Sid,tokenSid),
            new Claim(JwtRegisteredClaimNames.AuthTime,dtExpired.ToString("yyyy-MM-dd hh:mm:ss"))};

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            if (!string.IsNullOrEmpty(tokenIssuer) & !string.IsNullOrEmpty(tokenKey) & key != null & dtExpired != null & claims != null
                & creds != null)
            {
                var token = new JwtSecurityToken(tokenIssuer,tokenAudience,claims,
                  expires: dtExpired,
                  signingCredentials: creds);
                this.CreateCacheTokenSid(tokenSid);
                var myToken = new JwtSecurityTokenHandler().WriteToken(token);
                result.AccessToken = myToken;
                result.SIDToken = tokenSid;
            }
            return result;
        }

        public void CreateCacheTokenSid(string guidSID)
        {
            DateTimeOffset limitHourTime = DateTimeOffset.Now.AddHours(this.tokenSIDHourLimit);
            guidSID =guidSID.Replace("-", "");
            cacher.Add(guidSID, guidSID, limitHourTime);
        }

        public bool IsCacheTokenSidExists(string guidSID)
        {
            guidSID = guidSID.Replace("-", "");
            if (cacher.GetValue(guidSID) != null) return true;
            return false;
        }

        public bool SecurityTokenVerification(JwtSecurityToken accessToken)
        {
            bool result = false;
            if (accessToken != null)
            {
                if (accessToken.Payload != null)
                {
                    if (accessToken.Payload.ContainsKey("sid"))
                    {
                        object sidData = null;
                        accessToken.Payload.TryGetValue("sid", out sidData);
                        if (sidData != null)
                        {
                            result = this.IsCacheTokenSidExists(sidData.ToString());
                            
                        }
                    }
                }
            }
            return result;
        }
    }
    
}
