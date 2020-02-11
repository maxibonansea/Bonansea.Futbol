namespace Bonansea.Futbol.Application.DTO
{
    public class ContratoJugadorDto
    {
        public int IdContratoJugador { get; set; }

        public int IdEquipo { get; set; }

        public int IdJugador { get; set; }

        public bool Activo { get; set; }

        public double Monto { get; set; }

        public string Moneda { get; set; }

        public string FechaInicio { get; set; }

        public string FechaFin { get; set; }
    }
}
