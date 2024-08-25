using Ilumno.Core.Common.Repositories;
using Ilumno.Core.TiposDocumentos.Models;

namespace Ilumno.Core.TiposDocumentos.Repositories;

public interface ITipoDocumentoRepository : IGenericRepository<TipoDocumento>
{
    Task<TipoDocumento?> GetById(int? id);
}
