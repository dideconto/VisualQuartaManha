using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using API.Models;
using Microsoft.IdentityModel.Tokens;

namespace API.Services
{
    public static class TokenService
    {
        public static string CriarToken(Usuario usuario)
        {
            //Objeto que vai criar o token
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] key = Encoding.ASCII.GetBytes(Settings.secretKey);
            //Descrição do token
            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                //RefreshToken
                Expires = DateTime.UtcNow.AddHours(2),
                //Escolher qual a forma de encriptação
                SigningCredentials = new SigningCredentials
                (
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature
                ),
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuario.Email), //User.Identity.Name
                    new Claim(ClaimTypes.Role, usuario.Permissao)
                })
            };
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}