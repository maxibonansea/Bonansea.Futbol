using Bonansea.Futbol.Domain.Entity;
using Bonansea.Futbol.Infraestructure.Interface;
using Bonansea.Futbol.Transversal.Common;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Bonansea.Futbol.Infraestructure.Repository
{
    class ContratoJugadorRepository : IContratoJugadorRepository
    {
        private readonly IConnetionFactory _connetionFactory;

        public ContratoJugadorRepository(IConnetionFactory connetionFactory)
        {
            _connetionFactory = connetionFactory;
        }

        #region Métodos Síncronos

        public bool Insert(ContratoJugador contratoJugador)
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "ContratoJugadorInsert";
            //    var parameters = new DynamicParameters();
            //    parameters.Add("IdContratoJugador", contratoJugador.IdContratoJugador);
            //    parameters.Add("Nombre", contratoJugador.Nombre);
            //    parameters.Add("Apellido", contratoJugador.Apellido);
            //    parameters.Add("FechaNacimiento", contratoJugador.FechaNacimiento);
            //    parameters.Add("Edad", contratoJugador.Edad);
            //    parameters.Add("Nacionalidad", contratoJugador.Nacionalidad);

            //    var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
            //    return result > 0;
            //}
        }

        public bool Update(ContratoJugador contratoJugador)
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "ContratoJugadorUpdate";
            //    var parameters = new DynamicParameters();
            //    parameters.Add("IdContratoJugador", contratoJugador.IdContratoJugador);
            //    parameters.Add("Nombre", contratoJugador.Nombre);
            //    parameters.Add("Apellido", contratoJugador.Apellido);
            //    parameters.Add("FechaNacimiento", contratoJugador.FechaNacimiento);
            //    parameters.Add("Edad", contratoJugador.Edad);
            //    parameters.Add("Nacionalidad", contratoJugador.Nacionalidad);

            //    var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
            //    return result > 0;
            //}
        }

        public bool Delete(int idContratoJugador)
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "ContratoJugadorDelete";
            //    var parameters = new DynamicParameters();
            //    parameters.Add("IdContratoJugador", idContratoJugador);
            //    var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
            //    return result > 0;
            //}
        }

        public ContratoJugador Get(int idContratoJugador)
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "ContratoJugadorGetById";
            //    var parameters = new DynamicParameters();
            //    parameters.Add("IdContratoJugador", idContratoJugador);
            //    var contratoJugador = connection.QuerySingle<ContratoJugador>(query, param: parameters, commandType: CommandType.StoredProcedure);
            //    return contratoJugador;
            //}
        }

        public IEnumerable<ContratoJugador> GetAll()
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "ContratoJugadorList";
            //    var contratoJugadores = connection.Query<ContratoJugador>(query, commandType: CommandType.StoredProcedure);
            //    return contratoJugadores;
            //}
        }

        #endregion

        #region Métodos Asíncronos

        public async Task<bool> InsertAsync(ContratoJugador contratoJugador)
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "ContratoJugadorInsert";
            //    var parameters = new DynamicParameters();
            //    parameters.Add("IdContratoJugador", contratoJugador.IdContratoJugador);
            //    parameters.Add("Nombre", contratoJugador.Nombre);
            //    parameters.Add("Apellido", contratoJugador.Apellido);
            //    parameters.Add("FechaNacimiento", contratoJugador.FechaNacimiento);
            //    parameters.Add("Edad", contratoJugador.Edad);
            //    parameters.Add("Nacionalidad", contratoJugador.Nacionalidad);

            //    var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
            //    return result > 0;
            //}
        }

        public async Task<bool> UpdateAsync(ContratoJugador contratoJugador)
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "ContratoJugadorUpdate";
            //    var parameters = new DynamicParameters();
            //    parameters.Add("IdContratoJugador", contratoJugador.IdContratoJugador);
            //    parameters.Add("Nombre", contratoJugador.Nombre);
            //    parameters.Add("Apellido", contratoJugador.Apellido);
            //    parameters.Add("FechaNacimiento", contratoJugador.FechaNacimiento);
            //    parameters.Add("Edad", contratoJugador.Edad);
            //    parameters.Add("Nacionalidad", contratoJugador.Nacionalidad);

            //    var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
            //    return result > 0;
            //}
        }

        public async Task<bool> DeleteAsync(int idContratoJugador)
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "ContratoJugadorDelete";
            //    var parameters = new DynamicParameters();
            //    parameters.Add("IdContratoJugador", idContratoJugador);
            //    var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
            //    return result > 0;
            //}
        }

        public async Task<ContratoJugador> GetAsync(int idContratoJugador)
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "ContratoJugadorGetById";
            //    var parameters = new DynamicParameters();
            //    parameters.Add("IdContratoJugador", idContratoJugador);
            //    var contratoJugador = await connection.QuerySingleAsync<ContratoJugador>(query, param: parameters, commandType: CommandType.StoredProcedure);
            //    return contratoJugador;
            //}
        }

        public async Task<IEnumerable<ContratoJugador>> GetAllAsync()
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "ContratoJugadorList";
            //    var contratoJugadores = await connection.QueryAsync<ContratoJugador>(query, commandType: CommandType.StoredProcedure);
            //    return contratoJugadores;
            //}
        }

        #endregion
    }
}
