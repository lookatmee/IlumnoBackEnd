using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ilumno.Data.EF.Migrations
{
    /// <inheritdoc />
    public partial class ForumlarioMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formulario_Paises_PaisId",
                table: "Formulario");

            migrationBuilder.DropForeignKey(
                name: "FK_Formulario_TipoDocumentos_TipoDocumentoId",
                table: "Formulario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Formulario",
                table: "Formulario");

            migrationBuilder.RenameTable(
                name: "Formulario",
                newName: "Formularios");

            migrationBuilder.RenameIndex(
                name: "IX_Formulario_TipoDocumentoId",
                table: "Formularios",
                newName: "IX_Formularios_TipoDocumentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Formulario_PaisId",
                table: "Formularios",
                newName: "IX_Formularios_PaisId");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Formularios",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroDocumento",
                table: "Formularios",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Formularios",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CorreoElectronico",
                table: "Formularios",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Formularios",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreandoEn",
                table: "Formularios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Formularios",
                table: "Formularios",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Formularios",
                columns: new[] { "Id", "Apellido", "CorreoElectronico", "CreandoEn", "Nombre", "NumeroDocumento", "PaisId", "Telefono", "TipoDocumentoId" },
                values: new object[,]
                {
                    { new Guid("088301ff-1c68-419b-8cd7-e3a0699bc959"), "Suárez", "diana.suarez@example.com", new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diana", "5566778899", 3, "000111222", 1 },
                    { new Guid("19c22d2a-c670-4a0a-918f-ca649f03bbdc"), "Cruz", "ricardo.cruz@example.com", new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ricardo", "2233445566", 5, "777888999", 1 },
                    { new Guid("2765618b-8d80-462b-8894-0966e0b79ffe"), "Ortiz", "manuel.ortiz@example.com", new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manuel", "4455667788", 2, "999000111", 2 },
                    { new Guid("2958aa47-57e5-4c7e-99fd-51d074cc1d01"), "García", "juan.garcia@example.com", new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", "1234567890", 1, "123456789", 1 },
                    { new Guid("359b3be5-0485-413e-95cf-b08aabbb5cde"), "Morales", "jose.morales@example.com", new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "José", "9900112233", 2, "444555666", 2 },
                    { new Guid("4ada24cb-a5f6-45fe-a3ce-251f8ab6bfc0"), "López", "laura.lopez@example.com", new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", "9988776655", 4, "444555666", 2 },
                    { new Guid("4f14b2d7-4b96-4278-b927-c9f7a23e1484"), "Castro", "gabriela.castro@example.com", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriela", "8899001122", 1, "333444555", 1 },
                    { new Guid("6a70184b-83a5-44d2-8c24-a8c625a17e5e"), "Rodríguez", "carlos.rodriguez@example.com", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "1122334455", 3, "111222333", 1 },
                    { new Guid("6e3f2d30-aea2-45f5-adc7-9e1db06b0157"), "Pérez", "lucia.perez@example.com", new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucía", "5566778899", 3, "000111222", 1 },
                    { new Guid("72f357a1-e135-48f0-a211-bad81898fe2f"), "Gutiérrez", "andrea.gutierrez@example.com", new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrea", "7788990011", 5, "222333444", 1 },
                    { new Guid("7d785c76-2fa3-4695-b440-6e22fdab6dd3"), "Ramírez", "sofia.ramirez@example.com", new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sofía", "6677889900", 4, "111222333", 2 },
                    { new Guid("7d81007f-12ba-4ecd-b56d-7f1b1a7bbc5f"), "Hernández", "miguel.hernandez@example.com", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miguel", "2233445566", 5, "777888999", 1 },
                    { new Guid("83936fb3-a702-4d17-a024-5d7f32d98d49"), "Fernández", "daniel.fernandez@example.com", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", "7788990011", 5, "222333444", 1 },
                    { new Guid("a903c596-43eb-48fe-9bf5-68b86b0a128b"), "Díaz", "andres.diaz@example.com", new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrés", "4455667788", 2, "999000111", 2 },
                    { new Guid("d15e213c-8e72-478a-a34b-3243ea174700"), "Gómez", "maria.gomez@example.com", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "María", "3344556677", 1, "888999000", 1 },
                    { new Guid("e0b7e2ef-5bb2-4567-8c3e-6d1fd2673e5b"), "Martínez", "ana.martinez@example.com", new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", "9876543210", 2, "987654321", 2 },
                    { new Guid("e34c5792-2d07-4c0d-beb5-11353c3ad026"), "Ríos", "valentina.rios@example.com", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valentina", "1122334455", 4, "666777888", 2 },
                    { new Guid("e5a8430d-85ef-4786-9bfe-f39a22ef96e6"), "Sánchez", "paula.sanchez@example.com", new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paula", "3344556677", 1, "888999000", 1 },
                    { new Guid("f49f5d51-b791-417f-a177-c92ce6db0633"), "Mendoza", "diego.mendoza@example.com", new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diego", "6677889900", 4, "111222333", 2 },
                    { new Guid("fd9e1a6e-98d3-4368-92f5-19ed3eeb707f"), "Vargas", "camila.vargas@example.com", new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camila", "0011223344", 3, "555666777", 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Formularios_Paises_PaisId",
                table: "Formularios",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Formularios_TipoDocumentos_TipoDocumentoId",
                table: "Formularios",
                column: "TipoDocumentoId",
                principalTable: "TipoDocumentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formularios_Paises_PaisId",
                table: "Formularios");

            migrationBuilder.DropForeignKey(
                name: "FK_Formularios_TipoDocumentos_TipoDocumentoId",
                table: "Formularios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Formularios",
                table: "Formularios");

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("088301ff-1c68-419b-8cd7-e3a0699bc959"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("19c22d2a-c670-4a0a-918f-ca649f03bbdc"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("2765618b-8d80-462b-8894-0966e0b79ffe"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("2958aa47-57e5-4c7e-99fd-51d074cc1d01"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("359b3be5-0485-413e-95cf-b08aabbb5cde"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("4ada24cb-a5f6-45fe-a3ce-251f8ab6bfc0"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("4f14b2d7-4b96-4278-b927-c9f7a23e1484"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("6a70184b-83a5-44d2-8c24-a8c625a17e5e"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("6e3f2d30-aea2-45f5-adc7-9e1db06b0157"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("72f357a1-e135-48f0-a211-bad81898fe2f"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("7d785c76-2fa3-4695-b440-6e22fdab6dd3"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("7d81007f-12ba-4ecd-b56d-7f1b1a7bbc5f"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("83936fb3-a702-4d17-a024-5d7f32d98d49"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("a903c596-43eb-48fe-9bf5-68b86b0a128b"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("d15e213c-8e72-478a-a34b-3243ea174700"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("e0b7e2ef-5bb2-4567-8c3e-6d1fd2673e5b"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("e34c5792-2d07-4c0d-beb5-11353c3ad026"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("e5a8430d-85ef-4786-9bfe-f39a22ef96e6"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("f49f5d51-b791-417f-a177-c92ce6db0633"));

            migrationBuilder.DeleteData(
                table: "Formularios",
                keyColumn: "Id",
                keyValue: new Guid("fd9e1a6e-98d3-4368-92f5-19ed3eeb707f"));

            migrationBuilder.DropColumn(
                name: "CreandoEn",
                table: "Formularios");

            migrationBuilder.RenameTable(
                name: "Formularios",
                newName: "Formulario");

            migrationBuilder.RenameIndex(
                name: "IX_Formularios_TipoDocumentoId",
                table: "Formulario",
                newName: "IX_Formulario_TipoDocumentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Formularios_PaisId",
                table: "Formulario",
                newName: "IX_Formulario_PaisId");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Formulario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "NumeroDocumento",
                table: "Formulario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Formulario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "CorreoElectronico",
                table: "Formulario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Formulario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Formulario",
                table: "Formulario",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Formulario_Paises_PaisId",
                table: "Formulario",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Formulario_TipoDocumentos_TipoDocumentoId",
                table: "Formulario",
                column: "TipoDocumentoId",
                principalTable: "TipoDocumentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
