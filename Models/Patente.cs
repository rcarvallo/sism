using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Patente
{
    public int IdPatente { get; set; }

    public int? IdCliente { get; set; }

    public int? IdGeneradores { get; set; }

    public int IdTransporte { get; set; }

    public string? Patente1 { get; set; }

    public string? Numero { get; set; }

    public string? Patentecarro { get; set; }

    public string? Tipo { get; set; }

    public int? Tara { get; set; }

    public string? Largo { get; set; }

    public sbyte? CamionCsm { get; set; }

    public sbyte? CamionMulticliente { get; set; }

    public sbyte? CamionToleranca { get; set; }

    public string? Observaciones { get; set; }

    public int? Estado { get; set; }

    public string? TransferenciaCliente { get; set; }
}
