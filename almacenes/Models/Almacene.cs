using System;
using System.Collections.Generic;

namespace almacenes.Models;

public partial class Almacene
{
    public int Codigo { get; set; }

    public string? Lugar { get; set; }

    public int? Capacidad { get; set; }
}
