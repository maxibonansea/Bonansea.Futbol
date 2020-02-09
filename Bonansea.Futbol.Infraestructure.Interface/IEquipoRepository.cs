using Bonansea.Futbol.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bonansea.Futbol.Infraestructure.Interface
{
    public interface IEquipoRepository
    {
        #region Métodos Síncronos

        bool Insert(Equipo equipo);
        bool Update(Equipo equipo);
        bool Delete(int idEquipo);
        Equipo Get(int idEquipo);
        IEnumerable<Equipo> GetAll();

        #endregion

        #region Métodos Asíncronos

        Task<bool> InsertAsync(Equipo equipo);
        Task<bool> UpdateAsync(Equipo equipo);
        Task<bool> DeleteAsync(int idEquipo);
        Task<Equipo> GetAsync(int idEquipo);
        Task<IEnumerable<Equipo>> GetAllAsync();

        #endregion
    }
}
