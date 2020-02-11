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
    public class EquipoApplication : IEquipoApplication
    {
        private readonly IEquipoDomain _equipoDomain;
        private readonly IMapper _mapper;
        private readonly IAppLogger<EquipoApplication> _logger;

        public EquipoApplication(IEquipoDomain equipoDomain, IMapper mapper, IAppLogger<EquipoApplication> logger)
        {
            _equipoDomain = equipoDomain;
            _mapper = mapper;
            _logger = logger;
        }

        #region Métodos Síncronos

        public Response<bool> Insert(EquipoDto equipoDto)
        {
            var response = new Response<bool>();
            try
            {
                var equipo = _mapper.Map<Equipo>(equipoDto);
                response.Data = _equipoDomain.Insert(equipo);
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

        public Response<bool> Update(EquipoDto equipoDto)
        {
            var response = new Response<bool>();
            try
            {
                var equipo = _mapper.Map<Equipo>(equipoDto);
                response.Data = _equipoDomain.Update(equipo);
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

        public Response<bool> Delete(int idEquipo)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _equipoDomain.Delete(idEquipo);
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

        public Response<EquipoDto> Get(int idEquipo)
        {
            var response = new Response<EquipoDto>();
            try
            {
                var equipo = _equipoDomain.Get(idEquipo);
                response.Data = _mapper.Map<EquipoDto>(equipo);
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

        public Response<IEnumerable<EquipoDto>> GetAll()
        {
            var response = new Response<IEnumerable<EquipoDto>>();
            try
            {
                var equipoes = _equipoDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<EquipoDto>>(equipoes);
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

        public async Task<Response<bool>> InsertAsync(EquipoDto equipoDto)
        {
            var response = new Response<bool>();
            try
            {
                var equipo = _mapper.Map<Equipo>(equipoDto);
                response.Data = await _equipoDomain.InsertAsync(equipo);
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

        public async Task<Response<bool>> UpdateAsync(EquipoDto equipoDto)
        {
            var response = new Response<bool>();
            try
            {
                var equipo = _mapper.Map<Equipo>(equipoDto);
                response.Data = await _equipoDomain.UpdateAsync(equipo);
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

        public async Task<Response<bool>> DeleteAsync(int idEquipo)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _equipoDomain.DeleteAsync(idEquipo);
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

        public async Task<Response<EquipoDto>> GetAsync(int idEquipo)
        {
            var response = new Response<EquipoDto>();
            try
            {
                var equipo = await _equipoDomain.GetAsync(idEquipo);
                response.Data = _mapper.Map<EquipoDto>(equipo);
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

        public async Task<Response<IEnumerable<EquipoDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<EquipoDto>>();
            try
            {
                var equipoes = await _equipoDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<EquipoDto>>(equipoes);
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
