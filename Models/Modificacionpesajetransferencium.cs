using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Modificacionpesajetransferencium
{
    public int Idmodificacionpesaje { get; set; }

    public int? IdPatente { get; set; }

    public int? IdClienteProveedor { get; set; }

    public int? IdGenerador { get; set; }

    public int? IdGenerador2 { get; set; }

    public int? IdTipodeResiduo { get; set; }

    public int? IdTransporte { get; set; }

    public int? IdChofer { get; set; }

    public string? ObservacionDeEntrada { get; set; }

    public string? ObservacionDeSalida { get; set; }

    public string? Memorandum { get; set; }

    public int? PesoEntrada { get; set; }

    public int? PesoSalida { get; set; }

    public int? PesoNeto { get; set; }

    public string? Impresora { get; set; }

    public string? LavadoCamion { get; set; }

    public string? Iso14001 { get; set; }

    public int? TipoPesaje { get; set; }

    public string? Patente { get; set; }

    public string? PapeleraSesma { get; set; }

    public int? Estado { get; set; }

    public int? Personal { get; set; }

    public int? PersonalSalida { get; set; }

    public string? DescIso14001 { get; set; }

    public int? Planta { get; set; }

    public DateTime? FechaYhoraSalidaEtps { get; set; }

    public DateTime? FechayHoraEntradaRelleno { get; set; }

    public DateTime? FechaYhoraSalidaRelleno { get; set; }

    public DateTime? FechaYhoraEntradaEtps { get; set; }

    public DateTime? FechaYhoraEntradaRellEst { get; set; }

    public DateTime? FechaYhoraSalidaRellEst { get; set; }

    public DateTime? FechaYhoraSalidaTransEst { get; set; }

    public string? Rampla { get; set; }

    public string? Supervisor { get; set; }

    public string? FechaEdicion { get; set; }

    public string? MotivoModificacion { get; set; }

    public int? EditadoPor { get; set; }
}
