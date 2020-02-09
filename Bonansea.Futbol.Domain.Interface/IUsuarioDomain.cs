using Bonansea.Futbol.Domain.Entity;

namespace Bonansea.Futbol.Domain.Interface
{
    public interface IUsuarioDomain
    {
        Usuario Authenticate(string nombreUsuario, string contrasena);
    }
}
