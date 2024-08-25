using AutoMapper;
using Ilumno.Api.Controllers.Dtos.TipoDocumento;
using Ilumno.Core.TiposDocumentos.Models;

namespace Ilumno.Api.Autommapings;

public class TipoDocumentoProfile : Profile
{
    public TipoDocumentoProfile()
    {
        // Mapea de TipoDocumento a TipoDocumentoDto
        CreateMap<TipoDocumento, TipoDocumentoDto>();

        // Mapea de TipoDocumentoBaseDto a TipoDocumento
        CreateMap<TipoDocumentoBaseDto, TipoDocumento>();
    }
}
