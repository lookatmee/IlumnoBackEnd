using Ilumno.Core.Paises.Models;

namespace Ilumno.Core.Paises.Services;

public interface IPaisService
{
    Task<Pais> GetById(int id);
    Task<IEnumerable<Pais>> GetAll();
    Task Add(Pais pais);
    Task Update(Pais pais);
    Task Delete(int id);    
}
