using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Residuo
{
    public int IdResiduos { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? Guia { get; set; }

    public int? Estado { get; set; }
}
