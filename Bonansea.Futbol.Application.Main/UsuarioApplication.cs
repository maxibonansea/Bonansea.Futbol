using AutoMapper;
using Bonansea.Futbol.Application.DTO;
using Bonansea.Futbol.Application.Interface;
using Bonansea.Futbol.Domain.Interface;
using Bonansea.Futbol.Transversal.Common;
using System;

namespace Bonansea.Futbol.Application.Main
{
    public class UsuarioApplication : IUsuarioApplication
    {
        private readonly IUsuarioDomain _usuarioDomain;
        private readonly IMapper _mapper;

        public UsuarioApplication(IUsuarioDomain usuarioDomain, IMapper mapper)
        {
            _usuarioDomain = usuarioDomain;
            _mapper = mapper;
        }

        public Response<UsuarioDto> Authenticate(string nombreUsuario, string contrasena)
        {
            var response = new Response<UsuarioDto>();
            if(string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasena))
            {
                response.Message = "Los Parámetros no pueden ser vacíos.";
                return response;
            }
            try
            {
                var usuario = _usuarioDomain.Authenticate(nombreUsuario, contrasena);
                response.Data = _mapper.Map<UsuarioDto>(usuario);
                response.IsSuccess = true;
                response.Message = "Autenticación Exitosa.";
            }
            catch (InvalidOperationException)
            {
                response.IsSuccess = true;
                response.Message = "El Usuario no existe.";
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }
    }
}
