using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Transferencium
{
    public int PesNum { get; set; }

    public DateTime? PesFechaHora { get; set; }

    public string? CamPatente { get; set; }

    public string? CamNumero { get; set; }

    public string? NumSesma { get; set; }

    public string? CpvRut { get; set; }

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

    public int? PrdCodigo { get; set; }

    public string? PrdDescripcion { get; set; }

    public int? PesBruto { get; set; }

    public int? PesTara { get; set; }

    public int? PesNeto { get; set; }

    public decimal? PesTon { get; set; }

    public string? PesFechasalida { get; set; }

    public string? PesFechaentrada { get; set; }

    public string? PesHorasalida { get; set; }

    public string? PesHoraentrada { get; set; }

    public string? IdOperadorEntrada { get; set; }

    public string? IdOperadorSalida { get; set; }

    public int? IdSistema { get; set; }

    public string? SupNombre { get; set; }

    public string? Rampla { get; set; }

    public string? Hora1 { get; set; }

    public string? Hora2 { get; set; }

    public string? Hora3 { get; set; }

    public string? Hora4 { get; set; }

    public TimeOnly? PesPermanencia { get; set; }

    public string? ObservacionDeEntrada { get; set; }
}
