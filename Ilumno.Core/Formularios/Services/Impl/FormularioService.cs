using FluentValidation;
using Ilumno.Core.Common.Exceptions;
using Ilumno.Core.Common.Models;
using Ilumno.Core.Formularios.Models;
using Ilumno.Core.Formularios.Repositories;

namespace Ilumno.Core.Formularios.Services.Impl;

public class FormularioService(IFormularioRepository formularioRepository, IValidator<Formulario> validator) : IFormularioService
{
    private IFormularioRepository FormularioRepository { get; } = formularioRepository;
    public IValidator<Formulario> Validator { get; } = validator;

    public async Task Add(Formulario formulario)
    {
        formulario.Id = Guid.NewGuid();
        var validationFormulario = await Validator.ValidateAsync(formulario);

        if (!validationFormulario.IsValid)
        {
            throw new ValidationException(validationFormulario.Errors);
        }
        await FormularioRepository.AddAsync(formulario);
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Formulario>> GetAll()
    {
        var formularios = await FormularioRepository.GetAllAsync();
        return formularios;
    }

    public async Task<Formulario> GetById(Guid id)
    {
        var formulario = await FormularioRepository.GetById(id);

        if (formulario is null)
        {
            throw new NotFoundException($"El formulario {id} no existe.");
        }
        return formulario;
    }

    public Task Update(Formulario formulario)
    {
        throw new NotImplementedException();
    }

    public async Task<KeySetPaginated<Formulario>> GetAllPaginated(Guid? referenceProductId)
    {
        var formularioReference = await FormularioRepository.GetById(referenceProductId);
        var formularioPaginated = await FormularioRepository.GetAllPaginated(new KeySetPaginationBase<Formulario>
        {
            Reference = formularioReference
        });
        return formularioPaginated;
    }
}
