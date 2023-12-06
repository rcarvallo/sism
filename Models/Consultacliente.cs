using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace sism.Models;

public partial class Consultacliente
{
    [DisplayName("Ticket")]
    public int PesNum { get; set; }

    [DisplayName("Hora")]
    public string? PesHora { get; set; }

    [DisplayName("Fecha")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
    [DataType(DataType.Date)]
    public DateTime? PesFecha { get; set; }

    [DisplayName("Patente")]
    public string? CamPatente { get; set; }

    public string? CamNumero { get; set; }

    public string? NumSesma { get; set; }

    public string? CpvRut { get; set; }

    [DisplayName("Cliente")]
    public string? CpvRazonsocial { get; set; }

    public string? CpvTipo { get; set; }

    public string? TrnRut { get; set; }

    public string? TrnNombre { get; set; }

    public int? GnrCodigo { get; set; }

    public string? GnrRut { get; set; }

    public string? GnrNombre { get; set; }

    public string? GnrDireccion { get; set; }

    public int? ChfCodigo { get; set; }

    public string? ChfRut { get; set; }

    public string? ChfNombre { get; set; }

    public string? PrdCodigo { get; set; }

    public string? PrdDescripcion { get; set; }

    public int? PesBruto { get; set; }

    public int? PesTara { get; set; }

    public int? PesNeto { get; set; }

    [DisplayName("Toneladas")]
    public decimal? PesTon { get; set; }

    public string? PesFechaent { get; set; }

    public string? PesFechasal { get; set; }

    public string? PesHoraent { get; set; }

    public string? PesHorasal { get; set; }

    public string? IdOperadorEntrada { get; set; }

    public string? IdOperadorSalida { get; set; }

    public string? IdSistema { get; set; }

    public string? FiltroSistema { get; set; }

    public int? PesLavado { get; set; }

    [DisplayName("Fecha y Hora")]
    public DateTime? FechaYhoraEntrada { get; set; }

    public DateTime? FechaYhoraSalida { get; set; }

    public DateOnly? FechaEntrada { get; set; }

    public DateOnly? FechaSalida { get; set; }

    public TimeOnly? HoraEntrada { get; set; }

    public TimeOnly? HoraSalida { get; set; }

    [DisplayName("Permanencia")]
    public string? PesPermanencia { get; set; } 

    public string PesTramoHora { get; set; } = null!;

    public string? Generador2 { get; set; }

    public string? ObservacionDeEntrada { get; set; }

    public string? ObservacionDeSalida { get; set; }

    public int? Estado { get; set; }

    public string? Iso14001 { get; set; }
}
