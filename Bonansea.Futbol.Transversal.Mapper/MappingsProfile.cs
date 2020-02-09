using System;
using AutoMapper;
using Bonansea.Futbol.Domain.Entity;
using Bonansea.Futbol.Application.DTO;

namespace Bonansea.Futbol.Transversal.Mapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            //Mapeo cuando los Campos COINCIDEN en Nombre y Tipo entre todos los Objetos.
            CreateMap<Jugador, JugadorDto>().ReverseMap();

            //Ejemplo: Mapeo cuando los Campos NO COINCIDEN en Nombre y Tipo entre todos los Objetos.
            //CreateMap<Jugador, JugadorDto>().ReverseMap()
            //    .ForMember(destination => destination.IdJugador, source => source.MapFrom(src => src.IdJugador))
            //    .ForMember(destination => destination.Nombre, source => source.MapFrom(src => src.Nombre))
            //    .ForMember(destination => destination.Apellido, source => source.MapFrom(src => src.Apellido))
            //    .ForMember(destination => destination.FechaNacimiento, source => source.MapFrom(src => src.FechaNacimiento))
            //    .ForMember(destination => destination.Edad, source => source.MapFrom(src => src.Edad))
            //    .ForMember(destination => destination.Nacionalidad, source => source.MapFrom(src => src.Nacionalidad));
        }
    }
}
