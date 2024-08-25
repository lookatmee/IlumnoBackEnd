using Ilumno.Core.Common.Models;
using Ilumno.Core.Common.Repositories;
using Ilumno.Core.Formularios.Models;

namespace Ilumno.Core.Formularios.Repositories;

public interface IFormularioRepository : IGenericRepository<Formulario>
{
    Task<Formulario?> GetById(Guid? id);
    Task<IEnumerable<Formulario>> GetAllAsync();
    Task<KeySetPaginated<Formulario>> GetAllPaginated(KeySetPaginationBase<Formulario> options);
}
