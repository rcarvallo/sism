using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Comuna
{
    public int IdComuna { get; set; }

    public string Comuna1 { get; set; } = null!;

    public int IdRegion { get; set; }
}
