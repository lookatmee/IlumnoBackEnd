using FluentValidation;
using Ilumno.Core.Paises.Models;
using Ilumno.Core.Paises.Repositories;

namespace Ilumno.Core.Paises.Services.Impl;

public class PaisService(IPaisRepository paisRepository, IValidator<Pais> validator) : IPaisService
{
    private IPaisRepository PaisRepository { get; } = paisRepository;
    public IValidator<Pais> Validator { get; } = validator;

    public Task Add(Pais pais)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Pais>> GetAll()
    {
        var paises = await PaisRepository.GetAllAsync();
        return paises;
    }

    public Task<Pais> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task Update(Pais pais)
    {
        throw new NotImplementedException();
    }
}
