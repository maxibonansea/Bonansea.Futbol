using Bonansea.Futbol.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bonansea.Futbol.Domain.Interface
{
    public interface IJugadorDomain
    {
        #region Métodos Síncronos

        bool Insert(Jugador jugador);
        bool Update(Jugador jugador);
        bool Delete(int idJugador);
        Jugador Get(int idJugador);
        IEnumerable<Jugador> GetAll();

        #endregion

        #region Métodos Asíncronos

        Task<bool> InsertAsync(Jugador jugador);
        Task<bool> UpdateAsync(Jugador jugador);
        Task<bool> DeleteAsync(int idJugador);
        Task<Jugador> GetAsync(int idJugador);
        Task<IEnumerable<Jugador>> GetAllAsync();

        #endregion
    }
}
