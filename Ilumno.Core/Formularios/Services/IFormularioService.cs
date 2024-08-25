using Ilumno.Core.Common.Models;
using Ilumno.Core.Formularios.Models;

namespace Ilumno.Core.Formularios.Services;

public interface IFormularioService
{
    Task<Formulario> GetById(Guid id);
    Task<IEnumerable<Formulario>> GetAll();
    Task Add(Formulario formulario);
    Task Update(Formulario formulario);
    Task Delete(Guid id);
    Task<KeySetPaginated<Formulario>> GetAllPaginated(Guid? referenceProductId);
}
