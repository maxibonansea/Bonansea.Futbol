using System;
using Bonansea.Futbol.Domain.Entity;
using Bonansea.Futbol.Domain.Interface;
using Bonansea.Futbol.Infraestructure.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Bonansea.Futbol.Domain.Core
{
    public class JugadorDomain : IJugadorDomain
    {
        private readonly IJugadorRepository _jugadorRepository;

        public JugadorDomain(IJugadorRepository jugadorRepository)
        {
            _jugadorRepository = jugadorRepository;
        }

        #region Métodos Síncronos

        public bool Insert(Jugador jugador)
        {
            return _jugadorRepository.Insert(jugador);
            
        }

        public bool Update(Jugador jugador)
        {
            return _jugadorRepository.Update(jugador);
        }

        public bool Delete(int idJugador)
        {
            return _jugadorRepository.Delete(idJugador);
        }

        public Jugador Get(int idJugador)
        {
            return _jugadorRepository.Get(idJugador);
        }

        public IEnumerable<Jugador> GetAll()
        {
            return _jugadorRepository.GetAll();
        }

        #endregion

        #region Métodos Asíncronos

        public async Task<bool> InsertAsync(Jugador jugador)
        {
            return await _jugadorRepository.InsertAsync(jugador);
        }

        public async Task<bool> UpdateAsync(Jugador jugador)
        {
            return await _jugadorRepository.UpdateAsync(jugador);
        }

        public async Task<bool> DeleteAsync(int idJugador)
        {
            return await _jugadorRepository.DeleteAsync(idJugador);
        }

        public async Task<Jugador> GetAsync(int idJugador)
        {
            return await _jugadorRepository.GetAsync(idJugador);
        }

        public async Task<IEnumerable<Jugador>> GetAllAsync()
        {
            return await _jugadorRepository.GetAllAsync();
        }

        #endregion

    }
}
