using Ilumno.Core.Common.Repositories;
using Ilumno.Core.Paises.Models;

namespace Ilumno.Core.Paises.Repositories;

public interface IPaisRepository : IGenericRepository<Pais>
{
    Task<Pais?> GetById(int? id);
}
