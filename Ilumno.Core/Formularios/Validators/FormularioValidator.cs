using FluentValidation;
using Ilumno.Core.Formularios.Models;

namespace Ilumno.Core.Formularios.Validators;

public class FormularioValidator : AbstractValidator<Formulario>
{
    public FormularioValidator()
    {
        RuleFor(f => f.Apellido)
                .NotEmpty().WithMessage("El apellido es requerido.")
                .MaximumLength(100).WithMessage("El apellido no puede exceder los 100 caracteres.");

        RuleFor(f => f.Nombre)
            .NotEmpty().WithMessage("El nombre es requerido.")
            .MaximumLength(100).WithMessage("El nombre no puede exceder los 100 caracteres.");

        RuleFor(f => f.NumeroDocumento)
            .NotEmpty().WithMessage("El número de documento es requerido.")
            .MaximumLength(50).WithMessage("El número de documento no puede exceder los 50 caracteres.");

        RuleFor(f => f.CorreoElectronico)
            .NotEmpty().WithMessage("El correo electrónico es requerido.")
            .EmailAddress().WithMessage("El correo electrónico no es válido.")
            .MaximumLength(255).WithMessage("El correo electrónico no puede exceder los 255 caracteres.");

        RuleFor(f => f.Telefono)
            .NotEmpty().WithMessage("El teléfono es requerido.")
            .MaximumLength(20).WithMessage("El teléfono no puede exceder los 20 caracteres.");

        RuleFor(f => f.TipoDocumentoId)
            .NotEmpty().WithMessage("El tipo de documento es requerido.");

        RuleFor(f => f.PaisId)
            .NotEmpty().WithMessage("El país es requerido.");
    }
}
