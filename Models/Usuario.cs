using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Usuario
{
    public int IdUsuarios { get; set; }

    public int? IdGrupoUsuario { get; set; }

    public string? NombreUsuario { get; set; }

    public string? Clave { get; set; }

    public sbyte? Estado { get; set; }
}
