using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Contactocliente
{
    public int Id { get; set; }

    public int DsClientesId { get; set; }

    public string? Tipo { get; set; }

    public string? Nombre { get; set; }

    public string? Cargo { get; set; }

    public string? Email { get; set; }

    public string? Codarea { get; set; }

    public string? Telefonofijo { get; set; }

    public string? Fax { get; set; }

    public string? Movil { get; set; }

    public int? Estado { get; set; }
}
