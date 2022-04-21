using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using real_estate_web.Models.Database;
using real_estate_web.Tools.TokenOperations.Models;

namespace real_estate_web.Tools.TokenOperations
{
    public class TokenHandler
    {
        private IConfiguration Configuration { get; set; }
        public TokenHandler(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public Token CreateAccessToken(User person)
        {
            Token tokenModel = new Token();
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Token:SecurityKey"]));
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            tokenModel.Expiration = DateTime.UtcNow.AddMinutes(60);

            JwtSecurityToken securityToken = new JwtSecurityToken(
                issuer: Configuration["Token:Issuer"],
                audience: Configuration["Token:Audience"],
                expires: tokenModel.Expiration,
                notBefore: DateTime.UtcNow,
                claims: SetClaims(person),
                signingCredentials: credentials
            );
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            tokenModel.AccessToken = tokenHandler.WriteToken(securityToken);
            tokenModel.RefreshToken = CreateRefreshToken();

            return tokenModel;

        }

        public string CreateRefreshToken()
        {
            return Guid.NewGuid().ToString();
        }

        private IEnumerable<Claim> SetClaims(User person)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, person.Id.ToString()));
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, person.Email));
            claims.Add(new Claim(ClaimTypes.Name, $"{person.FirstName} {person.LastName}"));
            claims.Add(new Claim(ClaimTypes.Role, person.Role));
            claims.Add(new Claim("ProfilePhotoPath", person.ProfilePhotoPath));

            return claims;
        }
    }
}
