using Ilumno.Core.TiposDocumentos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ilumno.Data.EF.Mappings;

public class TipoDocumentoMapping : IEntityTypeConfiguration<TipoDocumento>
{
    public void Configure(EntityTypeBuilder<TipoDocumento> builder)
    {
        // Configuración de la tabla
        builder.ToTable("TipoDocumentos");

        // Configuración de la clave primaria
        builder.HasKey(td => td.Id);

        // Configuración de las propiedades
        builder.Property(td => td.Id)
            .IsRequired();

        builder.Property(td => td.Nombre)
            .IsRequired()
            .HasMaxLength(100);

        // Configuración de índices (opcional)
        builder.HasIndex(td => td.Nombre)
            .IsUnique();

        // Configuración de la relación con Formulario
        builder.HasMany(td => td.Formularios)
            .WithOne(f => f.TipoDocumento)
            .HasForeignKey(f => f.TipoDocumentoId)
            .OnDelete(DeleteBehavior.Restrict);

        // Datos iniciales
        builder.HasData(
            new TipoDocumento { Id = 1, Nombre = "Cédula de Ciudadanía" },
            new TipoDocumento { Id = 2, Nombre = "Cédula de Extrangería" }
        );
    }
}
