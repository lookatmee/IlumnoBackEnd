using Ilumno.Core.Formularios.Models;

namespace Ilumno.Core.Paises.Models;

public class Pais
{
    public int Id { get; set; }
    public string Nombre { get; set; }

    // Colección de formularios asociados a este país
    public ICollection<Formulario> Formularios { get; set; } = new List<Formulario>();
}
