using System;
using Bonansea.Futbol.Transversal.Common;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Bonansea.Futbol.Infraestructura.Data
{
    public class ConnectionFactory : IConnetionFactory
    {
        public readonly IConfiguration _configuration;

        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetConnection
        {
            get
            {
                var sqlConnection = new SqlConnection();
                if (sqlConnection == null) return null;

                sqlConnection.ConnectionString = _configuration.GetConnectionString("NOMBRE_CONEXION_BD");
                sqlConnection.Open();
                return sqlConnection;
            }
        }
    }
}
