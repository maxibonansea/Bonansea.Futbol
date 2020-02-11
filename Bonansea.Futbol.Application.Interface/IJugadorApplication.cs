using Bonansea.Futbol.Application.DTO;
using Bonansea.Futbol.Transversal.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bonansea.Futbol.Application.Interface
{
    public interface IJugadorApplication
    {
        #region Métodos Síncronos

        Response<bool> Insert(JugadorDto jugadorDto);
        Response<bool> Update(JugadorDto jugadorDto);
        Response<bool> Delete(int idJugador);
        Response<JugadorDto> Get(int idJugador);
        Response<IEnumerable<JugadorDto>> GetAll();

        #endregion

        #region Métodos Asíncronos

        Task<Response<bool>> InsertAsync(JugadorDto jugadorDto);
        Task<Response<bool>> UpdateAsync(JugadorDto jugadorDto);
        Task<Response<bool>> DeleteAsync(int idJugador);
        Task<Response<JugadorDto>> GetAsync(int idJugador);
        Task<Response<IEnumerable<JugadorDto>>> GetAllAsync();

        #endregion
    }
}
