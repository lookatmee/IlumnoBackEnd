using Ilumno.Core.Paises.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ilumno.Data.EF.Mappings;

public class PaisMapping : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        // Configuración de la tabla
        builder.ToTable("Paises");

        // Configuración de la clave primaria
        builder.HasKey(p => p.Id);

        // Configuración de las propiedades
        builder.Property(p => p.Id)
            .IsRequired();

        builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(100);

        // Configuración de índices (opcional)
        builder.HasIndex(p => p.Nombre)
            .IsUnique();

        // Configuración de la relación con Formulario
        builder.HasMany(p => p.Formularios)
            .WithOne(f => f.Pais)
            .HasForeignKey(f => f.PaisId)
            .OnDelete(DeleteBehavior.Restrict);

        // Datos iniciales
        builder.HasData(
            new Pais { Id = 1, Nombre = "Colombia" },
            new Pais { Id = 2, Nombre = "Perú" },
            new Pais { Id = 3, Nombre = "Panamá" },
            new Pais { Id = 4, Nombre = "Argentina" },
            new Pais { Id = 5, Nombre = "Chile" }
        );
    }
}
