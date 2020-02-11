using Bonansea.Futbol.Domain.Entity;
using Bonansea.Futbol.Domain.Interface;
using Bonansea.Futbol.Infraestructure.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Bonansea.Futbol.Domain.Core
{
    class ContratoJugadorDomain : IContratoJugadorDomain
    {
        private readonly IContratoJugadorRepository _contratoJugadorRepository;

        public ContratoJugadorDomain(IContratoJugadorRepository contratoJugadorRepository)
        {
            _contratoJugadorRepository = contratoJugadorRepository;
        }

        #region Métodos Síncronos

        public bool Insert(ContratoJugador contratoJugador)
        {
            return _contratoJugadorRepository.Insert(contratoJugador);

        }

        public bool Update(ContratoJugador contratoJugador)
        {
            return _contratoJugadorRepository.Update(contratoJugador);
        }

        public bool Delete(int idContratoJugador)
        {
            return _contratoJugadorRepository.Delete(idContratoJugador);
        }

        public ContratoJugador Get(int idContratoJugador)
        {
            return _contratoJugadorRepository.Get(idContratoJugador);
        }

        public IEnumerable<ContratoJugador> GetAll()
        {
            return _contratoJugadorRepository.GetAll();
        }

        #endregion

        #region Métodos Asíncronos

        public async Task<bool> InsertAsync(ContratoJugador contratoJugador)
        {
            return await _contratoJugadorRepository.InsertAsync(contratoJugador);
        }

        public async Task<bool> UpdateAsync(ContratoJugador contratoJugador)
        {
            return await _contratoJugadorRepository.UpdateAsync(contratoJugador);
        }

        public async Task<bool> DeleteAsync(int idContratoJugador)
        {
            return await _contratoJugadorRepository.DeleteAsync(idContratoJugador);
        }

        public async Task<ContratoJugador> GetAsync(int idContratoJugador)
        {
            return await _contratoJugadorRepository.GetAsync(idContratoJugador);
        }

        public async Task<IEnumerable<ContratoJugador>> GetAllAsync()
        {
            return await _contratoJugadorRepository.GetAllAsync();
        }

        #endregion
    }
}
