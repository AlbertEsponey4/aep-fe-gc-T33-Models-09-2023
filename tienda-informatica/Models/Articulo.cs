using System;
using System.Collections.Generic;

namespace tiendaInformatica.Models;

public partial class Articulo
{
    public int Codigo { get; set; }

    public string? Nombre { get; set; }

    public int? Precio { get; set; }

    public int? Fabricante { get; set; }

    public virtual Fabricante? FabricanteNavigation { get; set; }
}
