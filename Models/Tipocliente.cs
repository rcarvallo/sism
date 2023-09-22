using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Tipocliente
{
    public int IdTipoCliente { get; set; }

    public string? Nombre { get; set; }

    public int? ClieProv { get; set; }

    public string? Estado { get; set; }
}
