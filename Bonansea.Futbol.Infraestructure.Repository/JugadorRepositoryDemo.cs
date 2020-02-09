using Bonansea.Futbol.Domain.Entity;
using Bonansea.Futbol.Infraestructure.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bonansea.Futbol.Infraestructure.Repository
{
    public class JugadorRepositoryDemo : IJugadorRepository
    {
        private List<Jugador> _listJugadores;

        public JugadorRepositoryDemo()
        {
            _listJugadores = new List<Jugador>()
            {
                new Jugador(){
                    IdJugador = 1,
                    Nombre = "Lionel",
                    Apellido = "Messi",
                    Edad = 33,
                    FechaNacimiento = "10/05/1990",
                    Nacionalidad = "Argentino"
                },
                new Jugador(){
                    IdJugador = 2,
                    Nombre = "Lautaro",
                    Apellido = "Martinez",
                    Edad = 21,
                    FechaNacimiento = "19/07/1996",
                    Nacionalidad = "Argentino"
                },
                new Jugador(){
                    IdJugador = 3,
                    Nombre = "Paulo",
                    Apellido = "Dybala",
                    Edad = 22,
                    FechaNacimiento = "21/10/1997",
                    Nacionalidad = "Argentino"
                }
            };
        }

        #region Métodos Síncronos

        public bool Insert(Jugador jugador)
        {
            throw new NotImplementedException();
        }

        public bool Update(Jugador jugador)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int idJugador)
        {
            throw new NotImplementedException();
        }

        public Jugador Get(int idJugador)
        {
            var jugador = _listJugadores.Find(x => x.IdJugador==idJugador);
            return jugador;
        }

        public IEnumerable<Jugador> GetAll()
        {
            var jugadores = _listJugadores;
            return jugadores;
        }

        #endregion

        #region Métodos Asíncronos

        public async Task<bool> InsertAsync(Jugador jugador)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(Jugador jugador)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(int idJugador)
        {
            throw new NotImplementedException();
        }

        public async Task<Jugador> GetAsync(int idJugador)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Jugador>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
