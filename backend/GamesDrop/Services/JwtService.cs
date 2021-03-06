using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using GamesDrop.Dtos;
using GamesDrop.Services.Interfaces;
using GamesDrop.Settings;
using Microsoft.IdentityModel.Tokens;

namespace GamesDrop.Services
{
    public class JwtService : IJwtService
    {
        private readonly JwtSettings _jwtSettings;

        public JwtService(JwtSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public string GetNewAccessToken(UserDto user, Guid accessTokenJti)
        {
            var userEmail = user.Email;
            var userRoles = user.Roles;

            var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Sub, user.Id),
                new(JwtRegisteredClaimNames.Jti, accessTokenJti.ToString()),
                new(JwtRegisteredClaimNames.Email, userEmail)
            };

            claims.AddRange(userRoles.Select(role => new Claim(ClaimTypes.Role, role)));

            var key = Encoding.ASCII.GetBytes(_jwtSettings.SigningKey);
            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddSeconds(Convert.ToDouble(_jwtSettings.AccessTokenLifeTimeInSeconds)),
                Issuer = _jwtSettings.Issuer,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}