using Ilumno.Core.TiposDocumentos.Models;
using Ilumno.Core.TiposDocumentos.Repositories;
using Ilumno.Data.EF.Common.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ilumno.Data.EF.Repositories;

public class TipoDocumentoRepository(BackEndDbContext dbContext)
    : GenericEfRepository<TipoDocumento, BackEndDbContext>(dbContext), ITipoDocumentoRepository
{
    public async Task<TipoDocumento?> GetById(int? id)
    {
        var tipoDocumento = await DbContext.TiposDocumentos.SingleOrDefaultAsync(x => x.Id == id);
        return tipoDocumento;
    }
}
