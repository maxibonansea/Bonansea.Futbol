using System;
using System.Collections.Generic;
using System.Text;
using Bonansea.Futbol.Domain.Entity;

namespace Bonansea.Futbol.Infraestructure.Interface
{
    public interface IUsuarioRepository
    {
        Usuario Authenticate(string nommbreUsuario, string contrasena);
    }
}
