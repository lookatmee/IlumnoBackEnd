using Ilumno.Core.Formularios.Models;

namespace Ilumno.Core.TiposDocumentos.Models;

public class TipoDocumento
{
    public int Id { get; set; }
    public string Nombre { get; set; }

    // Colección de formularios asociados a este tipo de documento
    public ICollection<Formulario> Formularios { get; set; } = new List<Formulario>();
}
