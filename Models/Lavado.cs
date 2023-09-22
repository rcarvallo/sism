using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Lavado
{
    public int IdLavado { get; set; }

    public string? Patente { get; set; }

    public int? IdTransporte { get; set; }

    public int? IdGenerador { get; set; }

    public int? IdConductor { get; set; }

    public int? IdOperador { get; set; }

    public int? FolioPesaje { get; set; }

    public string? FechaHoraIngreso { get; set; }

    public string? HoraSalida { get; set; }
}
