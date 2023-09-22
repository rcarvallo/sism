using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Patenteclientetransferencium
{
    public int IdPatenteCliente { get; set; }

    public string? IdPatente { get; set; }

    public string? IdCliente { get; set; }

    public string? Estado { get; set; }
}
