using System;
using AutoMapper;
using Bonansea.Futbol.Application.DTO;
using Bonansea.Futbol.Application.Interface;
using Bonansea.Futbol.Domain.Entity;
using Bonansea.Futbol.Domain.Interface;
using Bonansea.Futbol.Transversal.Common;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Bonansea.Futbol.Application.Main
{
    public class JugadorApplication : IJugadorApplication
    {
        private readonly IJugadorDomain _jugadorDomain;
        private readonly IMapper _mapper;
        private readonly IAppLogger<JugadorApplication> _logger;

        public JugadorApplication(IJugadorDomain jugadorDomain, IMapper mapper, IAppLogger<JugadorApplication> logger)
        {
            _jugadorDomain = jugadorDomain;
            _mapper = mapper;
            _logger = logger;
        }

        #region Métodos Síncronos

        public Response<bool> Insert(JugadorDto jugadorDto)
        {
            var response = new Response<bool>();
            try
            {
                var jugador = _mapper.Map<Jugador>(jugadorDto);
                response.Data = _jugadorDomain.Insert(jugador);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<bool> Update(JugadorDto jugadorDto)
        {
            var response = new Response<bool>();
            try
            {
                var jugador = _mapper.Map<Jugador>(jugadorDto);
                response.Data = _jugadorDomain.Update(jugador);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Exitosa";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<bool> Delete(int idJugador)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _jugadorDomain.Delete(idJugador);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Exitosa";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<JugadorDto> Get(int idJugador)
        {
            var response = new Response<JugadorDto>();
            try
            {
                var jugador = _jugadorDomain.Get(idJugador);
                response.Data = _mapper.Map<JugadorDto>(jugador);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<IEnumerable<JugadorDto>> GetAll()
        {
            var response = new Response<IEnumerable<JugadorDto>>();
            try
            {
                var jugadores = _jugadorDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<JugadorDto>>(jugadores);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa";
                    _logger.LogInformation("Consulta Exitosa");
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                _logger.LogError(e.Message);
            }
            return response;
        }

        #endregion

        #region Métodos Asíncronos

        public async Task<Response<bool>> InsertAsync(JugadorDto jugadorDto)
        {
            var response = new Response<bool>();
            try
            {
                var jugador = _mapper.Map<Jugador>(jugadorDto);
                response.Data = await _jugadorDomain.InsertAsync(jugador);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<bool>> UpdateAsync(JugadorDto jugadorDto)
        {
            var response = new Response<bool>();
            try
            {
                var jugador = _mapper.Map<Jugador>(jugadorDto);
                response.Data = await _jugadorDomain.UpdateAsync(jugador);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Exitosa";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<bool>> DeleteAsync(int idJugador)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _jugadorDomain.DeleteAsync(idJugador);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Exitosa";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<JugadorDto>> GetAsync(int idJugador)
        {
            var response = new Response<JugadorDto>();
            try
            {
                var jugador = await _jugadorDomain.GetAsync(idJugador);
                response.Data = _mapper.Map<JugadorDto>(jugador);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<IEnumerable<JugadorDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<JugadorDto>>();
            try
            {
                var jugadores = await _jugadorDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<JugadorDto>>(jugadores);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        #endregion
    }
}
