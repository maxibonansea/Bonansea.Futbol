using Bonansea.Futbol.Domain.Entity;
using Bonansea.Futbol.Domain.Interface;
using Bonansea.Futbol.Infraestructure.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Bonansea.Futbol.Domain.Core
{
    public class EquipoDomain : IEquipoDomain
    {
        private readonly IEquipoRepository _equipoRepository;

        public EquipoDomain(IEquipoRepository equipoRepository)
        {
            _equipoRepository = equipoRepository;
        }

        #region Métodos Síncronos

        public bool Insert(Equipo equipo)
        {
            return _equipoRepository.Insert(equipo);

        }

        public bool Update(Equipo equipo)
        {
            return _equipoRepository.Update(equipo);
        }

        public bool Delete(int idEquipo)
        {
            return _equipoRepository.Delete(idEquipo);
        }

        public Equipo Get(int idEquipo)
        {
            return _equipoRepository.Get(idEquipo);
        }

        public IEnumerable<Equipo> GetAll()
        {
            return _equipoRepository.GetAll();
        }

        #endregion

        #region Métodos Asíncronos

        public async Task<bool> InsertAsync(Equipo equipo)
        {
            return await _equipoRepository.InsertAsync(equipo);
        }

        public async Task<bool> UpdateAsync(Equipo equipo)
        {
            return await _equipoRepository.UpdateAsync(equipo);
        }

        public async Task<bool> DeleteAsync(int idEquipo)
        {
            return await _equipoRepository.DeleteAsync(idEquipo);
        }

        public async Task<Equipo> GetAsync(int idEquipo)
        {
            return await _equipoRepository.GetAsync(idEquipo);
        }

        public async Task<IEnumerable<Equipo>> GetAllAsync()
        {
            return await _equipoRepository.GetAllAsync();
        }

        #endregion

    }
}
