using System;
using System.Collections.Generic;

namespace sism.Models;

/// <summary>
/// CuFt/s
/// </summary>
public partial class Flujo
{
    public DateTime? Hora { get; set; }

    public float Valor { get; set; }
}
