using Bonansea.Futbol.Application.DTO;
using Bonansea.Futbol.Transversal.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bonansea.Futbol.Application.Interface
{
    public interface IEquipoApplication
    {
        #region Métodos Síncronos

        Response<bool> Insert(EquipoDto equipoDto);
        Response<bool> Update(EquipoDto equipoDto);
        Response<bool> Delete(int idEquipo);
        Response<EquipoDto> Get(int idEquipo);
        Response<IEnumerable<EquipoDto>> GetAll();

        #endregion

        #region Métodos Asíncronos

        Task<Response<bool>> InsertAsync(EquipoDto equipoDto);
        Task<Response<bool>> UpdateAsync(EquipoDto equipoDto);
        Task<Response<bool>> DeleteAsync(int idEquipo);
        Task<Response<EquipoDto>> GetAsync(int idEquipo);
        Task<Response<IEnumerable<EquipoDto>>> GetAllAsync();

        #endregion
    }
}
