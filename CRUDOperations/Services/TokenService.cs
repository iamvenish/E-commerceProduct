using CRUDOperations.models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CRUDOperations.Services
{
    public class TokenService
    {
        private readonly string _Key = "ThisIsMyVeryStrongSecretKeyForJwtToken12345";

        public string CreateService(User user)
        {
            var claim = new[]
            {
                new Claim(ClaimTypes.NameIdentifier , user.Id.ToString()),
                new Claim(ClaimTypes.Email , user.Email!)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Key));
            var credentials = new SigningCredentials(key , SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken
            (
                issuer: "MyApi",
                audience: "MyApiUsers",
                claims: claim,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
