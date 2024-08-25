using AutoMapper;
using Ilumno.Api.Controllers.Dtos.Pais;
using Ilumno.Core.Paises.Models;

namespace Ilumno.Api.Autommapings;

public class PaisProfile : Profile
{
    public PaisProfile()
    {
        // Mapea de Pais a PaisDto
        CreateMap<Pais, PaisDto>();

        // Mapea de PaisBaseDto a Pais
        CreateMap<PaisBaseDto, Pais>();
    }
}
