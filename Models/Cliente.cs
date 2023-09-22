using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string Rut { get; set; } = null!;

    public string Razonsocial { get; set; } = null!;

    public string? ClienteProveedor { get; set; }

    public string? TipoCliente { get; set; }

    public string? Giro { get; set; }

    public string Direccionfactura { get; set; } = null!;

    public string Comuna { get; set; } = null!;

    public string Ciudad { get; set; } = null!;

    public string Region { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public string? Casilla { get; set; }

    public string? LineaDeCredito { get; set; }

    public int? Estado { get; set; }

    public string? FechaPermitidaInicio { get; set; }

    public string? FechaPermitidaFin { get; set; }
}
