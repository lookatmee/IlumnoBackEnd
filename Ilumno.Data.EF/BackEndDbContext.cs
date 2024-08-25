using Ilumno.Core.Formularios.Models;
using Ilumno.Core.Paises.Models;
using Ilumno.Core.TiposDocumentos.Models;
using Ilumno.Data.EF.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Ilumno.Data.EF;

public class BackEndDbContext(DbContextOptions<BackEndDbContext> options) : DbContext(options)
{
    public DbSet<Pais> Paises { get; set; }
    public DbSet<TipoDocumento> TiposDocumentos { get; set; }
    public DbSet<Formulario> Formularios { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new PaisMapping().Configure(modelBuilder.Entity<Pais>());
        new TipoDocumentoMapping().Configure(modelBuilder.Entity<TipoDocumento>());
        new FormularioMapping().Configure(modelBuilder.Entity<Formulario>());
    }
}
