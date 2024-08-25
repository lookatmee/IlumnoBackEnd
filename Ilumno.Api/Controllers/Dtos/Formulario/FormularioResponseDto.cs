using Ilumno.Api.Controllers.Dtos.Pais;
using Ilumno.Api.Controllers.Dtos.TipoDocumento;

namespace Ilumno.Api.Controllers.Dtos.Formulario;

public class FormularioResponseDto
{
    public Guid Id { get; set; }

    public string Apellido { get; set; }

    public string Nombre { get; set; }

    public string NumeroDocumento { get; set; }

    public string CorreoElectronico { get; set; }

    public string Telefono { get; set; }

    // Navegación a las entidades relacionadas
    public TipoDocumentoDto TipoDocumento { get; set; }
    public PaisDto Pais { get; set; }
}
