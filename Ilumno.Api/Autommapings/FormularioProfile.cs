using AutoMapper;
using Ilumno.Api.Controllers.Dtos.Formulario;
using Ilumno.Api.Controllers.Dtos.Pais;
using Ilumno.Api.Controllers.Dtos.TipoDocumento;
using Ilumno.Core.Formularios.Models;

namespace Ilumno.Api.Autommapings;

public class FormularioProfile : Profile
{
    public FormularioProfile()
    {
        CreateMap<CreateFormularioDto, Formulario>();
        CreateMap<Formulario, FormularioDto>();
        CreateMap<Formulario, Formulario>().ForMember(d => d.Id, o => o.Ignore());
        CreateMap<Formulario, FormularioResponseDto>()
            .ForMember(dest => dest.TipoDocumento, opt => opt.MapFrom(src => new TipoDocumentoDto
            {
                Id = src.TipoDocumento.Id,
                Nombre = src.TipoDocumento.Nombre
            }))
            .ForMember(dest => dest.Pais, opt => opt.MapFrom(src => new PaisDto
            {
                Id = src.Pais.Id,
                Nombre = src.Pais.Nombre
            }));
    }
}
