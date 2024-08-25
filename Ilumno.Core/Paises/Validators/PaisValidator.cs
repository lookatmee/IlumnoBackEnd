using FluentValidation;
using Ilumno.Core.Paises.Models;

namespace Ilumno.Core.Paises.Validators;

public class PaisValidator : AbstractValidator<Pais>
{
    public PaisValidator()
    {
        RuleFor(pais => pais.Nombre)
                .NotEmpty().WithMessage("El nombre del país es requerido.")
                .MaximumLength(100).WithMessage("El nombre del país no puede exceder los 100 caracteres.");
    }
}
