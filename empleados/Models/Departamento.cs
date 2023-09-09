using System;
using System.Collections.Generic;

namespace empleados.Models;

public partial class Departamento
{
    public int Codigo { get; set; }

    public string? Nombre { get; set; }

    public int? Presupuesto { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
