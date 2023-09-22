using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Generadore
{
    public int Idgeneradores { get; set; }

    public string? Rut { get; set; }

    public string? RazonSocial { get; set; }

    public string? Direccion { get; set; }

    public string? Fonos { get; set; }

    public string? Email { get; set; }

    public string? Contacto { get; set; }

    public int? Estado { get; set; }

    public int? IdClientes { get; set; }
}
