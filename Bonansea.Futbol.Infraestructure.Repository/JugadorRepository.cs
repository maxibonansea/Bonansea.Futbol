using System;
using Bonansea.Futbol.Domain.Entity;
using Bonansea.Futbol.Infraestructure.Interface;
using Bonansea.Futbol.Transversal.Common;
using Dapper;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace Bonansea.Futbol.Infraestructure.Repository
{
    public class JugadorRepository : IJugadorRepository
    {
        private readonly IConnetionFactory _connetionFactory;

        public JugadorRepository(IConnetionFactory connetionFactory)
        {
            _connetionFactory = connetionFactory;
        }

        #region Métodos Síncronos

        public bool Insert(Jugador jugador)
        {
            using (var connection = _connetionFactory.GetConnection)
            {
                var query = "JugadorInsert";
                var parameters = new DynamicParameters();
                parameters.Add("IdJugador", jugador.IdJugador);
                parameters.Add("Nombre", jugador.Nombre);
                parameters.Add("Apellido", jugador.Apellido);
                parameters.Add("FechaNacimiento", jugador.FechaNacimiento);
                parameters.Add("Edad", jugador.Edad);
                parameters.Add("Nacionalidad", jugador.Nacionalidad);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public bool Update(Jugador jugador)
        {
            using (var connection = _connetionFactory.GetConnection)
            {
                var query = "JugadorUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("IdJugador", jugador.IdJugador);
                parameters.Add("Nombre", jugador.Nombre);
                parameters.Add("Apellido", jugador.Apellido);
                parameters.Add("FechaNacimiento", jugador.FechaNacimiento);
                parameters.Add("Edad", jugador.Edad);
                parameters.Add("Nacionalidad", jugador.Nacionalidad);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public bool Delete(int idJugador)
        {
            using (var connection = _connetionFactory.GetConnection)
            {
                var query = "JugadorDelete";
                var parameters = new DynamicParameters();
                parameters.Add("IdJugador", idJugador);
                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public Jugador Get(int idJugador)
        {
            using (var connection = _connetionFactory.GetConnection)
            {
                var query = "JugadorGetById";
                var parameters = new DynamicParameters();
                parameters.Add("IdJugador", idJugador);
                var jugador = connection.QuerySingle<Jugador>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return jugador;
            }
        }

        public IEnumerable<Jugador> GetAll()
        {
            using (var connection = _connetionFactory.GetConnection)
            {
                var query = "JugadorList";
                var jugadores = connection.Query<Jugador>(query, commandType: CommandType.StoredProcedure);
                return jugadores;
            }
        }

        #endregion

        #region Métodos Asíncronos

        public async Task<bool> InsertAsync(Jugador jugador)
        {
            using (var connection = _connetionFactory.GetConnection)
            {
                var query = "JugadorInsert";
                var parameters = new DynamicParameters();
                parameters.Add("IdJugador", jugador.IdJugador);
                parameters.Add("Nombre", jugador.Nombre);
                parameters.Add("Apellido", jugador.Apellido);
                parameters.Add("FechaNacimiento", jugador.FechaNacimiento);
                parameters.Add("Edad", jugador.Edad);
                parameters.Add("Nacionalidad", jugador.Nacionalidad);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<bool> UpdateAsync(Jugador jugador)
        {
            using (var connection = _connetionFactory.GetConnection)
            {
                var query = "JugadorUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("IdJugador", jugador.IdJugador);
                parameters.Add("Nombre", jugador.Nombre);
                parameters.Add("Apellido", jugador.Apellido);
                parameters.Add("FechaNacimiento", jugador.FechaNacimiento);
                parameters.Add("Edad", jugador.Edad);
                parameters.Add("Nacionalidad", jugador.Nacionalidad);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<bool> DeleteAsync(int idJugador)
        {
            using (var connection = _connetionFactory.GetConnection)
            {
                var query = "JugadorDelete";
                var parameters = new DynamicParameters();
                parameters.Add("IdJugador", idJugador);
                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<Jugador> GetAsync(int idJugador)
        {
            using (var connection = _connetionFactory.GetConnection)
            {
                var query = "JugadorGetById";
                var parameters = new DynamicParameters();
                parameters.Add("IdJugador", idJugador);
                var jugador = await connection.QuerySingleAsync<Jugador>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return jugador;
            }
        }

        public async Task<IEnumerable<Jugador>> GetAllAsync()
        {
            using (var connection = _connetionFactory.GetConnection)
            {
                var query = "JugadorList";
                var jugadores = await connection.QueryAsync<Jugador>(query, commandType: CommandType.StoredProcedure);
                return jugadores;
            }
        }

        #endregion

    }
}
