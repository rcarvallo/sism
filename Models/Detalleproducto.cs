using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Detalleproducto
{
    public int IdDetalleProducto { get; set; }

    public int IdCliente { get; set; }

    public int IdPersonal { get; set; }

    public int IdPesaje { get; set; }
}
