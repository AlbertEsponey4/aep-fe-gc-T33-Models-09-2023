using System;
using System.Collections.Generic;

namespace cine.Models;

public partial class Pelicula
{
    public int Codigo { get; set; }

    public string? Nombre { get; set; }

    public int? CalificacionEdad { get; set; }

    public virtual ICollection<Sala> Salas { get; set; } = new List<Sala>();
}
