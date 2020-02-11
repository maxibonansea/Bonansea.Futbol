using Bonansea.Futbol.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bonansea.Futbol.Domain.Interface
{
    public interface IContratoJugadorDomain
    {
        #region Métodos Síncronos

        bool Insert(ContratoJugador contratoJugador);
        bool Update(ContratoJugador contratoJugador);
        bool Delete(int idContratoJugador);
        ContratoJugador Get(int idContratoJugador);
        IEnumerable<ContratoJugador> GetAll();

        #endregion

        #region Métodos Asíncronos

        Task<bool> InsertAsync(ContratoJugador contratoJugador);
        Task<bool> UpdateAsync(ContratoJugador contratoJugador);
        Task<bool> DeleteAsync(int idContratoJugador);
        Task<ContratoJugador> GetAsync(int idContratoJugador);
        Task<IEnumerable<ContratoJugador>> GetAllAsync();

        #endregion
    }
}
