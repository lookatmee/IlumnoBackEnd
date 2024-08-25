using FluentValidation;
using Ilumno.Core.Common.Data.Impl;
using Ilumno.Core.Common.Data;
using Ilumno.Data.EF;
using Ilumno.Core.Paises.Services;
using Ilumno.Core.Paises.Services.Impl;
using Ilumno.Core.Paises.Repositories;
using Ilumno.Data.EF.Repositories;
using Ilumno.Core.Paises.Models;
using Ilumno.Core.Paises.Validators;
using Ilumno.Core.TiposDocumentos.Services;
using Ilumno.Core.TiposDocumentos.Services.Impl;
using Ilumno.Core.TiposDocumentos.Repositories;
using Ilumno.Core.TiposDocumentos.Models;
using Ilumno.Core.TiposDocumentos.Validators;
using Ilumno.Core.Formularios.Services;
using Ilumno.Core.Formularios.Services.Impl;
using Ilumno.Core.Formularios.Repositories;
using Ilumno.Core.Formularios.Models;
using Ilumno.Core.Formularios.Validators;

namespace Ilumno.Api.Infraestructure.Extensions;

public static class DependencyInjectionExtensions
{
    public static void RegisterDependencies(this IServiceCollection services)
    {
        services.RegisterServices();
        services.RegisterRepositories();
        services.RegisterValidators();
        services.RegisterUnitOfWork();
    }

    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IPaisService, PaisService>();
        services.AddScoped<ITipoDocumentoService, TipoDocumentoService>();
        services.AddScoped<IFormularioService, FormularioService>();
    }

    public static void RegisterRepositories(this IServiceCollection services)
    {
        services.AddScoped<IPaisRepository, PaisRepository>();
        services.AddScoped<ITipoDocumentoRepository, TipoDocumentoRepository>();
        services.AddScoped<IFormularioRepository, FormularioRepository>();
    }

    public static void RegisterValidators(this IServiceCollection services)
    {
        services.AddSingleton<IValidator<Pais>, PaisValidator>();
        services.AddSingleton<IValidator<TipoDocumento>, TipoDocumentoValidator>();
        services.AddSingleton<IValidator<Formulario>, FormularioValidator>();
    }

    public static void RegisterUnitOfWork(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, EfUnitOfWork<BackEndDbContext>>();
    }
}
