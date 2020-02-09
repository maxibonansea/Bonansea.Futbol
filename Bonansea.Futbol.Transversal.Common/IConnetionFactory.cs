using System.Data;

namespace Bonansea.Futbol.Transversal.Common
{
    public interface IConnetionFactory
    {
        IDbConnection GetConnection { get; }
    }
}
