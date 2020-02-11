using Bonansea.Futbol.Domain.Entity;
using Bonansea.Futbol.Infraestructure.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bonansea.Futbol.Infraestructure.Repository
{
    public class UsuarioRepositoryDemo : IUsuarioRepository
    {
        private List<Usuario> _listUsuarios;

        public UsuarioRepositoryDemo()
        {
            _listUsuarios = new List<Usuario>()
            {
                new Usuario(){
                    IdUsuario = 1,
                    NombreUsuario = "mbonansea",
                    Contrasena = "123456"
                },
                new Usuario(){
                    IdUsuario = 2,
                    NombreUsuario = "admin",
                    Contrasena = "123456"
                }
            };
        }

        public Usuario Authenticate(string nombreUsuario, string contrasena)
        {
            var user = _listUsuarios.Find(x => x.NombreUsuario == nombreUsuario && x.Contrasena == contrasena);
            return user;
        }
    }
}
