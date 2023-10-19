using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sism.Models;

/// <summary>
/// mg/l
/// </summary>
public partial class Dqo
{
    
    public DateTime? Hora { get; set; }

    public float Valor { get; set; }




}
