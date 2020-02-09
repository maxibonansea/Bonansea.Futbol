using Bonansea.Futbol.Domain.Entity;
using Bonansea.Futbol.Infraestructure.Interface;
using Bonansea.Futbol.Transversal.Common;
using Dapper;
using System.Data;

namespace Bonansea.Futbol.Infraestructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IConnetionFactory _connetionFactory;

        public UsuarioRepository(IConnetionFactory connetionFactory)
        {
            _connetionFactory = connetionFactory;
        }

        public Usuario Authenticate(string nombreUsuario, string contrasena)
        {
            using (var connection = _connetionFactory.GetConnection)
            {
                var query = "UsuarioGetByUserAndPassword";
                var parameters = new DynamicParameters();
                parameters.Add("NombreUsuario", nombreUsuario);
                parameters.Add("Contrasena", contrasena);

                var user = connection.QuerySingle<Usuario>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return user;
            }
        }
    }
}
