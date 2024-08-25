using FluentValidation;
using Ilumno.Core.TiposDocumentos.Models;

namespace Ilumno.Core.TiposDocumentos.Validators;

public class TipoDocumentoValidator : AbstractValidator<TipoDocumento>
{
    public TipoDocumentoValidator()
    {
        RuleFor(tipoDocumento => tipoDocumento.Nombre)
            .NotEmpty().WithMessage("El nombre del tipo de documento es requerido.")
            .MaximumLength(100).WithMessage("El nombre del tipo de documento no puede exceder los 100 caracteres.");
    }
}