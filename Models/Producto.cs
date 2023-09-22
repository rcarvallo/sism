using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Producto
{
    public int Idproducto { get; set; }

    public string Producto1 { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
