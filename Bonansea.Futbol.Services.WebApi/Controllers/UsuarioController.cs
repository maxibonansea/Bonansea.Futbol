using Bonansea.Futbol.Application.DTO;
using Bonansea.Futbol.Application.Interface;
using Bonansea.Futbol.Services.WebApi.Helpers;
using Bonansea.Futbol.Transversal.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Bonansea.Futbol.Services.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApplication _usuarioApplication;
        private readonly AppSettings _appSettings;

        public UsuarioController(IUsuarioApplication usuarioApplication, IOptions<AppSettings> appSettings)
        {
            _usuarioApplication = usuarioApplication;
            _appSettings = appSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Authenticate([FromBody]UsuarioDto UsuarioDto)
        {
            var response = _usuarioApplication.Authenticate(UsuarioDto.NombreUsuario, UsuarioDto.Contrasena);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                {
                    response.Data.Token = BuildToken(response);
                    return Ok(response);
                }
                else
                    return NotFound(response.Message);
            }
            return BadRequest(response.Message);
        }

        private string BuildToken(Response<UsuarioDto> UsuarioDto)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name, UsuarioDto.Data.IdUsuario.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(2),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                    Issuer = _appSettings.Issuer,
                    Audience = _appSettings.Audience
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                var tokenString = tokenHandler.WriteToken(token);
                return tokenString;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}