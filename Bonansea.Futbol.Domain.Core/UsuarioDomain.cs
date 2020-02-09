using Bonansea.Futbol.Domain.Entity;
using Bonansea.Futbol.Domain.Interface;
using Bonansea.Futbol.Infraestructure.Interface;

namespace Bonansea.Futbol.Domain.Core
{
    public class UsuarioDomain : IUsuarioDomain
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioDomain(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario Authenticate(string nombreUsuario, string contrasena)
        {
            return _usuarioRepository.Authenticate(nombreUsuario, contrasena);
        }
    }
}
