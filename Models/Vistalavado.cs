using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Vistalavado
{
    public int LavNum { get; set; }

    public string? LavFechaIng { get; set; }

    public string? LavFechaSal { get; set; }

    public string? CpvRazonsocial { get; set; }

    public string? TrnNombre { get; set; }

    public string? CamNumero { get; set; }

    public string? ChfNombre { get; set; }

    public int? PesNum { get; set; }
}
