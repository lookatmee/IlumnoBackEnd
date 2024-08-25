﻿namespace Ilumno.Api.Controllers.Dtos.Formulario;

public class FormularioDto
{
    public Guid Id { get; set; }
    public string Apellido { get; set; }
    public string Nombre { get; set; }
    public int TipoDocumentoId { get; set; }
    public string NumeroDocumento { get; set; }
    public string CorreoElectronico { get; set; }
    public string Telefono { get; set; }
    public int PaisId { get; set; }
}
