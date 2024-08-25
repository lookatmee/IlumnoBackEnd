using Ilumno.Core.Common.Models;
using Ilumno.Core.Formularios.Models;
using Ilumno.Core.Formularios.Repositories;
using Ilumno.Data.EF.Common.Repositories;
using Microsoft.EntityFrameworkCore;
using MR.EntityFrameworkCore.KeysetPagination;

namespace Ilumno.Data.EF.Repositories;

public class FormularioRepository(BackEndDbContext dbContext)
: GenericEfRepository<Formulario, BackEndDbContext>(dbContext), IFormularioRepository
{
    public async Task<IEnumerable<Formulario>> GetAllAsync()
    {
        var formularios = await DbContext.Formularios.Include(x => x.TipoDocumento).Include(y => y.Pais).ToListAsync();
        return formularios;
    }

    public async Task<KeySetPaginated<Formulario>> GetAllPaginated(KeySetPaginationBase<Formulario> options)
    {
        var quotesQuery = DbContext.Formularios.AsQueryable();

        var queryContext = quotesQuery.KeysetPaginate(
            KeysetQuery.Build<Formulario>(b => b.Ascending(x => x.Id).Descending(x => x.CreandoEn)),
            KeysetPaginationDirection.Forward,
            options.Reference);

        var formularioList = await queryContext.Query.Take(options.PageSize).ToListAsync();

        queryContext.EnsureCorrectOrder(formularioList);

        return new KeySetPaginated<Formulario>
        {
            Data = formularioList,
            HasNext = await queryContext.HasNextAsync(formularioList),
            HasPrevious = await queryContext.HasPreviousAsync(formularioList)
        };
    }

    public async Task<Formulario?> GetById(Guid? id)
    {
        var formulario = await DbContext.Formularios.SingleOrDefaultAsync(c => c.Id == id);
        return formulario;
    }
}
