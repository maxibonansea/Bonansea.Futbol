using System;
using System.Collections.Generic;
using System.Text;
using Bonansea.Futbol.Application.DTO;
using Bonansea.Futbol.Transversal.Common;

namespace Bonansea.Futbol.Application.Interface
{
    public interface IUsuarioApplication
    {
        Response<UsuarioDto> Authenticate(string nombreUsuario, string contrasena);
    }
}
