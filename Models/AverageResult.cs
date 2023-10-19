using System;
using System.Collections.Generic;

namespace sism.Models;

/// <summary>
/// mg/l
/// </summary>
public class AverageResult
{
    public DateTime Dia { get; set; }

    public double PromedioFlujo { get; set; }

    public double PromedioDQO { get; set; }
}
