﻿// <auto-generated />
using System;
using Ilumno.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ilumno.Data.EF.Migrations
{
    [DbContext(typeof(BackEndDbContext))]
    partial class BackEndDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ilumno.Core.Formularios.Models.Formulario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreandoEn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NumeroDocumento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PaisId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TipoDocumentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.HasIndex("TipoDocumentoId");

                    b.ToTable("Formularios", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("2958aa47-57e5-4c7e-99fd-51d074cc1d01"),
                            Apellido = "García",
                            CorreoElectronico = "juan.garcia@example.com",
                            CreandoEn = new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Juan",
                            NumeroDocumento = "1234567890",
                            PaisId = 1,
                            Telefono = "123456789",
                            TipoDocumentoId = 1
                        },
                        new
                        {
                            Id = new Guid("e0b7e2ef-5bb2-4567-8c3e-6d1fd2673e5b"),
                            Apellido = "Martínez",
                            CorreoElectronico = "ana.martinez@example.com",
                            CreandoEn = new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Ana",
                            NumeroDocumento = "9876543210",
                            PaisId = 2,
                            Telefono = "987654321",
                            TipoDocumentoId = 2
                        },
                        new
                        {
                            Id = new Guid("6a70184b-83a5-44d2-8c24-a8c625a17e5e"),
                            Apellido = "Rodríguez",
                            CorreoElectronico = "carlos.rodriguez@example.com",
                            CreandoEn = new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Carlos",
                            NumeroDocumento = "1122334455",
                            PaisId = 3,
                            Telefono = "111222333",
                            TipoDocumentoId = 1
                        },
                        new
                        {
                            Id = new Guid("4ada24cb-a5f6-45fe-a3ce-251f8ab6bfc0"),
                            Apellido = "López",
                            CorreoElectronico = "laura.lopez@example.com",
                            CreandoEn = new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Laura",
                            NumeroDocumento = "9988776655",
                            PaisId = 4,
                            Telefono = "444555666",
                            TipoDocumentoId = 2
                        },
                        new
                        {
                            Id = new Guid("7d81007f-12ba-4ecd-b56d-7f1b1a7bbc5f"),
                            Apellido = "Hernández",
                            CorreoElectronico = "miguel.hernandez@example.com",
                            CreandoEn = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Miguel",
                            NumeroDocumento = "2233445566",
                            PaisId = 5,
                            Telefono = "777888999",
                            TipoDocumentoId = 1
                        },
                        new
                        {
                            Id = new Guid("d15e213c-8e72-478a-a34b-3243ea174700"),
                            Apellido = "Gómez",
                            CorreoElectronico = "maria.gomez@example.com",
                            CreandoEn = new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "María",
                            NumeroDocumento = "3344556677",
                            PaisId = 1,
                            Telefono = "888999000",
                            TipoDocumentoId = 1
                        },
                        new
                        {
                            Id = new Guid("a903c596-43eb-48fe-9bf5-68b86b0a128b"),
                            Apellido = "Díaz",
                            CorreoElectronico = "andres.diaz@example.com",
                            CreandoEn = new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Andrés",
                            NumeroDocumento = "4455667788",
                            PaisId = 2,
                            Telefono = "999000111",
                            TipoDocumentoId = 2
                        },
                        new
                        {
                            Id = new Guid("6e3f2d30-aea2-45f5-adc7-9e1db06b0157"),
                            Apellido = "Pérez",
                            CorreoElectronico = "lucia.perez@example.com",
                            CreandoEn = new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Lucía",
                            NumeroDocumento = "5566778899",
                            PaisId = 3,
                            Telefono = "000111222",
                            TipoDocumentoId = 1
                        },
                        new
                        {
                            Id = new Guid("7d785c76-2fa3-4695-b440-6e22fdab6dd3"),
                            Apellido = "Ramírez",
                            CorreoElectronico = "sofia.ramirez@example.com",
                            CreandoEn = new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Sofía",
                            NumeroDocumento = "6677889900",
                            PaisId = 4,
                            Telefono = "111222333",
                            TipoDocumentoId = 2
                        },
                        new
                        {
                            Id = new Guid("83936fb3-a702-4d17-a024-5d7f32d98d49"),
                            Apellido = "Fernández",
                            CorreoElectronico = "daniel.fernandez@example.com",
                            CreandoEn = new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Daniel",
                            NumeroDocumento = "7788990011",
                            PaisId = 5,
                            Telefono = "222333444",
                            TipoDocumentoId = 1
                        },
                        new
                        {
                            Id = new Guid("4f14b2d7-4b96-4278-b927-c9f7a23e1484"),
                            Apellido = "Castro",
                            CorreoElectronico = "gabriela.castro@example.com",
                            CreandoEn = new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Gabriela",
                            NumeroDocumento = "8899001122",
                            PaisId = 1,
                            Telefono = "333444555",
                            TipoDocumentoId = 1
                        },
                        new
                        {
                            Id = new Guid("359b3be5-0485-413e-95cf-b08aabbb5cde"),
                            Apellido = "Morales",
                            CorreoElectronico = "jose.morales@example.com",
                            CreandoEn = new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "José",
                            NumeroDocumento = "9900112233",
                            PaisId = 2,
                            Telefono = "444555666",
                            TipoDocumentoId = 2
                        },
                        new
                        {
                            Id = new Guid("fd9e1a6e-98d3-4368-92f5-19ed3eeb707f"),
                            Apellido = "Vargas",
                            CorreoElectronico = "camila.vargas@example.com",
                            CreandoEn = new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Camila",
                            NumeroDocumento = "0011223344",
                            PaisId = 3,
                            Telefono = "555666777",
                            TipoDocumentoId = 1
                        },
                        new
                        {
                            Id = new Guid("e34c5792-2d07-4c0d-beb5-11353c3ad026"),
                            Apellido = "Ríos",
                            CorreoElectronico = "valentina.rios@example.com",
                            CreandoEn = new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Valentina",
                            NumeroDocumento = "1122334455",
                            PaisId = 4,
                            Telefono = "666777888",
                            TipoDocumentoId = 2
                        },
                        new
                        {
                            Id = new Guid("19c22d2a-c670-4a0a-918f-ca649f03bbdc"),
                            Apellido = "Cruz",
                            CorreoElectronico = "ricardo.cruz@example.com",
                            CreandoEn = new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Ricardo",
                            NumeroDocumento = "2233445566",
                            PaisId = 5,
                            Telefono = "777888999",
                            TipoDocumentoId = 1
                        },
                        new
                        {
                            Id = new Guid("e5a8430d-85ef-4786-9bfe-f39a22ef96e6"),
                            Apellido = "Sánchez",
                            CorreoElectronico = "paula.sanchez@example.com",
                            CreandoEn = new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Paula",
                            NumeroDocumento = "3344556677",
                            PaisId = 1,
                            Telefono = "888999000",
                            TipoDocumentoId = 1
                        },
                        new
                        {
                            Id = new Guid("2765618b-8d80-462b-8894-0966e0b79ffe"),
                            Apellido = "Ortiz",
                            CorreoElectronico = "manuel.ortiz@example.com",
                            CreandoEn = new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Manuel",
                            NumeroDocumento = "4455667788",
                            PaisId = 2,
                            Telefono = "999000111",
                            TipoDocumentoId = 2
                        },
                        new
                        {
                            Id = new Guid("088301ff-1c68-419b-8cd7-e3a0699bc959"),
                            Apellido = "Suárez",
                            CorreoElectronico = "diana.suarez@example.com",
                            CreandoEn = new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Diana",
                            NumeroDocumento = "5566778899",
                            PaisId = 3,
                            Telefono = "000111222",
                            TipoDocumentoId = 1
                        },
                        new
                        {
                            Id = new Guid("f49f5d51-b791-417f-a177-c92ce6db0633"),
                            Apellido = "Mendoza",
                            CorreoElectronico = "diego.mendoza@example.com",
                            CreandoEn = new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Diego",
                            NumeroDocumento = "6677889900",
                            PaisId = 4,
                            Telefono = "111222333",
                            TipoDocumentoId = 2
                        },
                        new
                        {
                            Id = new Guid("72f357a1-e135-48f0-a211-bad81898fe2f"),
                            Apellido = "Gutiérrez",
                            CorreoElectronico = "andrea.gutierrez@example.com",
                            CreandoEn = new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Andrea",
                            NumeroDocumento = "7788990011",
                            PaisId = 5,
                            Telefono = "222333444",
                            TipoDocumentoId = 1
                        });
                });

            modelBuilder.Entity("Ilumno.Core.Paises.Models.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Paises", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Colombia"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Perú"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Panamá"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Argentina"
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Chile"
                        });
                });

            modelBuilder.Entity("Ilumno.Core.TiposDocumentos.Models.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("TipoDocumentos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Cédula de Ciudadanía"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Cédula de Extrangería"
                        });
                });

            modelBuilder.Entity("Ilumno.Core.Formularios.Models.Formulario", b =>
                {
                    b.HasOne("Ilumno.Core.Paises.Models.Pais", "Pais")
                        .WithMany("Formularios")
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Ilumno.Core.TiposDocumentos.Models.TipoDocumento", "TipoDocumento")
                        .WithMany("Formularios")
                        .HasForeignKey("TipoDocumentoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pais");

                    b.Navigation("TipoDocumento");
                });

            modelBuilder.Entity("Ilumno.Core.Paises.Models.Pais", b =>
                {
                    b.Navigation("Formularios");
                });

            modelBuilder.Entity("Ilumno.Core.TiposDocumentos.Models.TipoDocumento", b =>
                {
                    b.Navigation("Formularios");
                });
#pragma warning restore 612, 618
        }
    }
}
