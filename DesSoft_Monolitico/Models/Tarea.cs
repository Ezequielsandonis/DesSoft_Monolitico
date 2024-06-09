using System;
using System.Collections.Generic;

namespace DesSoft_Monolitico.Models;

public partial class Tarea
{
    public int TareaId { get; set; }

    public string? Titulo { get; set; }

    public DateTime? FechaLimite { get; set; }

    public bool Estado { get; set; }
}
