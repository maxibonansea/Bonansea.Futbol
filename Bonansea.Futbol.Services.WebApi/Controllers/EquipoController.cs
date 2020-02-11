using Bonansea.Futbol.Application.DTO;
using Bonansea.Futbol.Application.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bonansea.Futbol.Services.WebApi.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {
        private readonly IEquipoApplication _equipoApplication;

        public EquipoController(IEquipoApplication equipoApplication)
        {
            _equipoApplication = equipoApplication;
        }

        #region "Métodos Síncronos"

        [HttpPost]
        public IActionResult Insert([FromBody]EquipoDto equipoDto)
        {
            if (equipoDto == null)
                return BadRequest();

            var response = _equipoApplication.Insert(equipoDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut]
        public IActionResult Update([FromBody]EquipoDto equipoDto)
        {
            if (equipoDto == null)
                return BadRequest();

            var response = _equipoApplication.Update(equipoDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("{IdEquipo}")]
        public IActionResult Delete(int IdEquipo)
        {
            if (IdEquipo == 0)
                return BadRequest();

            var response = _equipoApplication.Delete(IdEquipo);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("{IdEquipo}")]
        public IActionResult Get(int IdEquipo)
        {
            if (IdEquipo == 0)
                return BadRequest();

            var response = _equipoApplication.Get(IdEquipo);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _equipoApplication.GetAll();
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        #endregion

        #region "Métodos Asíncronos"

        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody]EquipoDto equipoDto)
        {
            if (equipoDto == null)
                return BadRequest();

            var response = await _equipoApplication.InsertAsync(equipoDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody]EquipoDto equipoDto)
        {
            if (equipoDto == null)
                return BadRequest();

            var response = await _equipoApplication.UpdateAsync(equipoDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("{IdEquipo}")]
        public async Task<IActionResult> DeleteAsync(int IdEquipo)
        {
            if (IdEquipo == 0)
                return BadRequest();

            var response = await _equipoApplication.DeleteAsync(IdEquipo);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("{IdEquipo}")]
        public async Task<IActionResult> GetAsync(int IdEquipo)
        {
            if (IdEquipo == 0)
                return BadRequest();

            var response = await _equipoApplication.GetAsync(IdEquipo);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _equipoApplication.GetAllAsync();
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        #endregion
    }
}