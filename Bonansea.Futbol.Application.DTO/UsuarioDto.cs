﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bonansea.Futbol.Application.DTO
{
    public class UsuarioDto
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreUsuario { get; set; }

        public string Contrasena { get; set; }

        public string Token { get; set; }
    }
}
