using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Chofer
{
    public int Idchofer { get; set; }

    public int? Transporte { get; set; }

    public string? Rut { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Fonos { get; set; }

    public int? Estado { get; set; }
}
