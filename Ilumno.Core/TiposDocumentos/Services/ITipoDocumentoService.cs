using Ilumno.Core.TiposDocumentos.Models;

namespace Ilumno.Core.TiposDocumentos.Services;

public interface ITipoDocumentoService
{
    Task<TipoDocumento> GetById(int id);
    Task<IEnumerable<TipoDocumento>> GetAll();
    Task Add(TipoDocumento tipoDocumento);
    Task Update(TipoDocumento tipoDocumento);
    Task Delete(int id);
}
