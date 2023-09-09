using System;
using System.Collections.Generic;

namespace empleados.Models;

public partial class Empleado
{
    public string Dni { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public int? Departamento { get; set; }

    public virtual Departamento? DepartamentoNavigation { get; set; }
}
