using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Patentememorandum
{
    public int IdPatenteMemorandum { get; set; }

    public int? IdPatente { get; set; }

    public int? IdCliente { get; set; }

    public string? Nombre { get; set; }

    public string? Folio { get; set; }

    public string? FechaEmision { get; set; }

    public string? FechaInicio { get; set; }

    public string? FechaFin { get; set; }

    public string? Estado { get; set; }
}
