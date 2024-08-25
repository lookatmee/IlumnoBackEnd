using FluentValidation;
using Ilumno.Core.TiposDocumentos.Models;
using Ilumno.Core.TiposDocumentos.Repositories;

namespace Ilumno.Core.TiposDocumentos.Services.Impl;

public class TipoDocumentoService(ITipoDocumentoRepository tipoDocumentoRepository, IValidator<TipoDocumento> validator) : ITipoDocumentoService
{
    private ITipoDocumentoRepository TipoDocumentoRepository { get; } = tipoDocumentoRepository;
    public IValidator<TipoDocumento> Validator { get; } = validator;

    public Task Add(TipoDocumento tipoDocumento)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<TipoDocumento>> GetAll()
    {
        var tipoDocumentos = await TipoDocumentoRepository.GetAllAsync();
        return tipoDocumentos;
    }

    public Task<TipoDocumento> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task Update(TipoDocumento tipoDocumento)
    {
        throw new NotImplementedException();
    }
}
