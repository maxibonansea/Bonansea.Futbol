using System.Collections.Generic;

namespace Bonansea.Futbol.Application.DTO
{
    public class EquipoDto
    {
        public int IdEquipo { get; set; }

        public string Nombre { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public List<ContratoJugadorDto> Contratos { get; set; }
    }
}
