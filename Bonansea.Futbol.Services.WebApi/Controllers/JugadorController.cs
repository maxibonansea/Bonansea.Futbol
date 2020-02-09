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
    public class JugadorController : ControllerBase
    {
        private readonly IJugadorApplication _jugadorApplication;

        public JugadorController(IJugadorApplication jugadorApplication)
        {
            _jugadorApplication = jugadorApplication;
        }

        #region "Métodos Síncronos"

        [HttpPost]
        public IActionResult Insert([FromBody]JugadorDto jugadorDto)
        {
            if (jugadorDto == null)
                return BadRequest();

            var response = _jugadorApplication.Insert(jugadorDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut]
        public IActionResult Update([FromBody]JugadorDto jugadorDto)
        {
            if (jugadorDto == null)
                return BadRequest();

            var response = _jugadorApplication.Update(jugadorDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("{IdJugador}")]
        public IActionResult Delete(int IdJugador)
        {
            if (IdJugador == 0)
                return BadRequest();

            var response = _jugadorApplication.Delete(IdJugador);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("{IdJugador}")]
        public IActionResult Get(int IdJugador)
        {
            if (IdJugador == 0)
                return BadRequest();

            var response = _jugadorApplication.Get(IdJugador);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _jugadorApplication.GetAll();
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        #endregion

        #region "Métodos Asíncronos"

        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody]JugadorDto jugadorDto)
        {
            if (jugadorDto == null)
                return BadRequest();

            var response = await _jugadorApplication.InsertAsync(jugadorDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody]JugadorDto jugadorDto)
        {
            if (jugadorDto == null)
                return BadRequest();

            var response = await _jugadorApplication.UpdateAsync(jugadorDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("{IdJugador}")]
        public async Task<IActionResult> DeleteAsync(int IdJugador)
        {
            if (IdJugador == 0)
                return BadRequest();

            var response = await _jugadorApplication.DeleteAsync(IdJugador);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("{IdJugador}")]
        public async Task<IActionResult> GetAsync(int IdJugador)
        {
            if (IdJugador == 0)
                return BadRequest();

            var response = await _jugadorApplication.GetAsync(IdJugador);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _jugadorApplication.GetAllAsync();
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        #endregion
    }
}