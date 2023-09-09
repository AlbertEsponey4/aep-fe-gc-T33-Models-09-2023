using System;
using System.Collections.Generic;

namespace almacenes.Models;

public partial class Caja
{
    public string NumReferencia { get; set; } = null!;

    public string? Contenido { get; set; }

    public int? Valor { get; set; }

    public int? Almacen { get; set; }
}
