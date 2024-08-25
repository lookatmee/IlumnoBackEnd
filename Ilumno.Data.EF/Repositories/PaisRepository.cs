using Ilumno.Core.Paises.Models;
using Ilumno.Core.Paises.Repositories;
using Ilumno.Data.EF.Common.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ilumno.Data.EF.Repositories;

public class PaisRepository(BackEndDbContext dbContext)
: GenericEfRepository<Pais, BackEndDbContext>(dbContext), IPaisRepository
{
    public async Task<Pais?> GetById(int? id)
    {
        var pais = await DbContext.Paises.SingleOrDefaultAsync(c => c.Id == id);
        return pais;
    }
}
