using System;

namespace Bonansea.Futbol.Application.DTO
{
    public class JugadorDto
    {
        public int IdJugador { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string FechaNacimiento { get; set; }

        public int Edad { get; set; }

        public string Nacionalidad { get; set; }
    }
}
