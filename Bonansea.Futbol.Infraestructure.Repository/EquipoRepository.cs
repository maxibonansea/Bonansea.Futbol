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
    public class EquipoRepository : IEquipoRepository
    {
        private readonly IConnetionFactory _connetionFactory;

        public EquipoRepository(IConnetionFactory connetionFactory)
        {
            _connetionFactory = connetionFactory;
        }

        #region Métodos Síncronos

        public bool Insert(Equipo equipo)
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "EquipoInsert";
            //    var parameters = new DynamicParameters();
            //    parameters.Add("IdEquipo", equipo.IdEquipo);
            //    parameters.Add("Nombre", equipo.Nombre);
            //    parameters.Add("Apellido", equipo.Apellido);
            //    parameters.Add("FechaNacimiento", equipo.FechaNacimiento);
            //    parameters.Add("Edad", equipo.Edad);
            //    parameters.Add("Nacionalidad", equipo.Nacionalidad);

            //    var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
            //    return result > 0;
            //}
        }

        public bool Update(Equipo equipo)
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "EquipoUpdate";
            //    var parameters = new DynamicParameters();
            //    parameters.Add("IdEquipo", equipo.IdEquipo);
            //    parameters.Add("Nombre", equipo.Nombre);
            //    parameters.Add("Apellido", equipo.Apellido);
            //    parameters.Add("FechaNacimiento", equipo.FechaNacimiento);
            //    parameters.Add("Edad", equipo.Edad);
            //    parameters.Add("Nacionalidad", equipo.Nacionalidad);

            //    var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
            //    return result > 0;
            //}
        }

        public bool Delete(int idEquipo)
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "EquipoDelete";
            //    var parameters = new DynamicParameters();
            //    parameters.Add("IdEquipo", idEquipo);
            //    var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
            //    return result > 0;
            //}
        }

        public Equipo Get(int idEquipo)
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "EquipoGetById";
            //    var parameters = new DynamicParameters();
            //    parameters.Add("IdEquipo", idEquipo);
            //    var equipo = connection.QuerySingle<Equipo>(query, param: parameters, commandType: CommandType.StoredProcedure);
            //    return equipo;
            //}
        }

        public IEnumerable<Equipo> GetAll()
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "EquipoList";
            //    var equipoes = connection.Query<Equipo>(query, commandType: CommandType.StoredProcedure);
            //    return equipoes;
            //}
        }

        #endregion

        #region Métodos Asíncronos

        public async Task<bool> InsertAsync(Equipo equipo)
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "EquipoInsert";
            //    var parameters = new DynamicParameters();
            //    parameters.Add("IdEquipo", equipo.IdEquipo);
            //    parameters.Add("Nombre", equipo.Nombre);
            //    parameters.Add("Apellido", equipo.Apellido);
            //    parameters.Add("FechaNacimiento", equipo.FechaNacimiento);
            //    parameters.Add("Edad", equipo.Edad);
            //    parameters.Add("Nacionalidad", equipo.Nacionalidad);

            //    var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
            //    return result > 0;
            //}
        }

        public async Task<bool> UpdateAsync(Equipo equipo)
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "EquipoUpdate";
            //    var parameters = new DynamicParameters();
            //    parameters.Add("IdEquipo", equipo.IdEquipo);
            //    parameters.Add("Nombre", equipo.Nombre);
            //    parameters.Add("Apellido", equipo.Apellido);
            //    parameters.Add("FechaNacimiento", equipo.FechaNacimiento);
            //    parameters.Add("Edad", equipo.Edad);
            //    parameters.Add("Nacionalidad", equipo.Nacionalidad);

            //    var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
            //    return result > 0;
            //}
        }

        public async Task<bool> DeleteAsync(int idEquipo)
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "EquipoDelete";
            //    var parameters = new DynamicParameters();
            //    parameters.Add("IdEquipo", idEquipo);
            //    var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
            //    return result > 0;
            //}
        }

        public async Task<Equipo> GetAsync(int idEquipo)
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "EquipoGetById";
            //    var parameters = new DynamicParameters();
            //    parameters.Add("IdEquipo", idEquipo);
            //    var equipo = await connection.QuerySingleAsync<Equipo>(query, param: parameters, commandType: CommandType.StoredProcedure);
            //    return equipo;
            //}
        }

        public async Task<IEnumerable<Equipo>> GetAllAsync()
        {
            throw new NotImplementedException();
            //using (var connection = _connetionFactory.GetConnection)
            //{
            //    var query = "EquipoList";
            //    var equipoes = await connection.QueryAsync<Equipo>(query, commandType: CommandType.StoredProcedure);
            //    return equipoes;
            //}
        }

        #endregion
    }
}
