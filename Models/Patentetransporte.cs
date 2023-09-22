using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Patentetransporte
{
    public int IdPatenteTransporte { get; set; }

    public string? IdPatente { get; set; }

    public string? IdTransporte { get; set; }

    public string? Estado { get; set; }
}
