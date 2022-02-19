using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration configuration;
        public LoginController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        /// <summary>
        /// 生成JWT字符串
        /// </summary>
        /// <param name="tokenModel"></param>
        /// <returns></returns>
        private string GetJWT(TokenModel tokenModel)
        {
            //DateTime utc = DateTime.UtcNow;
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti,JsonConvert.SerializeObject(tokenModel)),
                // 令牌颁发时间
                new Claim(JwtRegisteredClaimNames.Iat, $"{new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds()}"),
                new Claim(JwtRegisteredClaimNames.Nbf,$"{new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds()}"),
                // 过期时间 100秒
                new Claim(JwtRegisteredClaimNames.Exp,$"{new DateTimeOffset(DateTime.Now.AddSeconds(1000)).ToUnixTimeSeconds()}"),
                new Claim(JwtRegisteredClaimNames.Iss,"API"), // 签发者
                new Claim(JwtRegisteredClaimNames.Aud,"User") // 接收者
            };

            // 密钥
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetSection("secretKey").Value));
            //sha256加密规则
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken jwt = new JwtSecurityToken(
            claims: claims, // 声明的集合
                            //expires: .AddSeconds(36), // token的有效时间
            signingCredentials: creds
            );
            var handler = new JwtSecurityTokenHandler();
            // 生成 jwt字符串
            var strJWT = handler.WriteToken(jwt);
            return strJWT;
        }
    }
}
