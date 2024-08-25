using Ilumno.Core.Formularios.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ilumno.Data.EF.Mappings;

public class FormularioMapping : IEntityTypeConfiguration<Formulario>
{
    public void Configure(EntityTypeBuilder<Formulario> builder)
    {
        // Configuración de la tabla
        builder.ToTable("Formularios");

        // Configuración de la clave primaria
        builder.HasKey(f => f.Id);

        // Configuración de las propiedades
        builder.Property(f => f.Id)
            .IsRequired();

        builder.Property(f => f.Apellido)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(f => f.Nombre)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(f => f.NumeroDocumento)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(f => f.CorreoElectronico)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(f => f.Telefono)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(f => f.TipoDocumentoId)
            .IsRequired();

        builder.Property(f => f.PaisId)
            .IsRequired();

        // Configuración de la relación con TipoDocumento
        builder.HasOne(f => f.TipoDocumento)
            .WithMany(td => td.Formularios)
            .HasForeignKey(f => f.TipoDocumentoId)
            .OnDelete(DeleteBehavior.Restrict);

        // Configuración de la relación con Pais
        builder.HasOne(f => f.Pais)
            .WithMany(p => p.Formularios)
            .HasForeignKey(f => f.PaisId)
            .OnDelete(DeleteBehavior.Restrict);

        // Seed Data - Insertar 20 registros con fechas aleatorias
        var random = new Random();
        DateTime startDate = new DateTime(2024, 6, 11);
        DateTime endDate = new DateTime(2024, 8, 23);
        TimeSpan range = endDate - startDate;

        builder.HasData(
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "García",
                Nombre = "Juan",
                TipoDocumentoId = 1,
                NumeroDocumento = "1234567890",
                CorreoElectronico = "juan.garcia@example.com",
                Telefono = "123456789",
                PaisId = 1,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Martínez",
                Nombre = "Ana",
                TipoDocumentoId = 2,
                NumeroDocumento = "9876543210",
                CorreoElectronico = "ana.martinez@example.com",
                Telefono = "987654321",
                PaisId = 2,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Rodríguez",
                Nombre = "Carlos",
                TipoDocumentoId = 1,
                NumeroDocumento = "1122334455",
                CorreoElectronico = "carlos.rodriguez@example.com",
                Telefono = "111222333",
                PaisId = 3,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "López",
                Nombre = "Laura",
                TipoDocumentoId = 2,
                NumeroDocumento = "9988776655",
                CorreoElectronico = "laura.lopez@example.com",
                Telefono = "444555666",
                PaisId = 4,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Hernández",
                Nombre = "Miguel",
                TipoDocumentoId = 1,
                NumeroDocumento = "2233445566",
                CorreoElectronico = "miguel.hernandez@example.com",
                Telefono = "777888999",
                PaisId = 5,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Gómez",
                Nombre = "María",
                TipoDocumentoId = 1,
                NumeroDocumento = "3344556677",
                CorreoElectronico = "maria.gomez@example.com",
                Telefono = "888999000",
                PaisId = 1,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Díaz",
                Nombre = "Andrés",
                TipoDocumentoId = 2,
                NumeroDocumento = "4455667788",
                CorreoElectronico = "andres.diaz@example.com",
                Telefono = "999000111",
                PaisId = 2,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Pérez",
                Nombre = "Lucía",
                TipoDocumentoId = 1,
                NumeroDocumento = "5566778899",
                CorreoElectronico = "lucia.perez@example.com",
                Telefono = "000111222",
                PaisId = 3,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Ramírez",
                Nombre = "Sofía",
                TipoDocumentoId = 2,
                NumeroDocumento = "6677889900",
                CorreoElectronico = "sofia.ramirez@example.com",
                Telefono = "111222333",
                PaisId = 4,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Fernández",
                Nombre = "Daniel",
                TipoDocumentoId = 1,
                NumeroDocumento = "7788990011",
                CorreoElectronico = "daniel.fernandez@example.com",
                Telefono = "222333444",
                PaisId = 5,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Castro",
                Nombre = "Gabriela",
                TipoDocumentoId = 1,
                NumeroDocumento = "8899001122",
                CorreoElectronico = "gabriela.castro@example.com",
                Telefono = "333444555",
                PaisId = 1,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Morales",
                Nombre = "José",
                TipoDocumentoId = 2,
                NumeroDocumento = "9900112233",
                CorreoElectronico = "jose.morales@example.com",
                Telefono = "444555666",
                PaisId = 2,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Vargas",
                Nombre = "Camila",
                TipoDocumentoId = 1,
                NumeroDocumento = "0011223344",
                CorreoElectronico = "camila.vargas@example.com",
                Telefono = "555666777",
                PaisId = 3,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Ríos",
                Nombre = "Valentina",
                TipoDocumentoId = 2,
                NumeroDocumento = "1122334455",
                CorreoElectronico = "valentina.rios@example.com",
                Telefono = "666777888",
                PaisId = 4,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Cruz",
                Nombre = "Ricardo",
                TipoDocumentoId = 1,
                NumeroDocumento = "2233445566",
                CorreoElectronico = "ricardo.cruz@example.com",
                Telefono = "777888999",
                PaisId = 5,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Sánchez",
                Nombre = "Paula",
                TipoDocumentoId = 1,
                NumeroDocumento = "3344556677",
                CorreoElectronico = "paula.sanchez@example.com",
                Telefono = "888999000",
                PaisId = 1,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Ortiz",
                Nombre = "Manuel",
                TipoDocumentoId = 2,
                NumeroDocumento = "4455667788",
                CorreoElectronico = "manuel.ortiz@example.com",
                Telefono = "999000111",
                PaisId = 2,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Suárez",
                Nombre = "Diana",
                TipoDocumentoId = 1,
                NumeroDocumento = "5566778899",
                CorreoElectronico = "diana.suarez@example.com",
                Telefono = "000111222",
                PaisId = 3,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Mendoza",
                Nombre = "Diego",
                TipoDocumentoId = 2,
                NumeroDocumento = "6677889900",
                CorreoElectronico = "diego.mendoza@example.com",
                Telefono = "111222333",
                PaisId = 4,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            },
            new Formulario
            {
                Id = Guid.NewGuid(),
                Apellido = "Gutiérrez",
                Nombre = "Andrea",
                TipoDocumentoId = 1,
                NumeroDocumento = "7788990011",
                CorreoElectronico = "andrea.gutierrez@example.com",
                Telefono = "222333444",
                PaisId = 5,
                CreandoEn = startDate.AddDays(random.Next(range.Days))
            }
        );
    }
}
