using Ilumno.Core.Paises.Models;
using Ilumno.Core.TiposDocumentos.Models;

namespace Ilumno.Core.Formularios.Models;

public class Formulario
{
    public Guid Id { get; set; }

    public string Apellido { get; set; }

    public string Nombre { get; set; }

    public int TipoDocumentoId { get; set; }

    public string NumeroDocumento { get; set; }

    public string CorreoElectronico { get; set; }

    public string Telefono { get; set; }

    public int PaisId { get; set; }

    public DateTime CreandoEn { get; set; } = DateTime.UtcNow;

    // Navegación a las entidades relacionadas
    public TipoDocumento TipoDocumento { get; set; }
    public Pais Pais { get; set; }
}
