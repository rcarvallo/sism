using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Serial
{
    public int IdSerial { get; set; }

    public int? LargoString { get; set; }

    public int? InicioString { get; set; }

    public int? FinString { get; set; }

    public string? Comm { get; set; }

    public string? Indicador { get; set; }

    public string? Serie { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Observacion { get; set; }

    public string? IdPc { get; set; }
}
