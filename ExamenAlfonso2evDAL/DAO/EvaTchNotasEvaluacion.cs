using System;
using System.Collections.Generic;

namespace ExamenAlfonso2evDAL.DAO;

public partial class EvaTchNotasEvaluacion
{
    public string? MdUuid { get; set; }

    public DateTime? MdFch { get; set; }

    public int IdNotaEvaluacion { get; set; }

    public string CodAlumno { get; set; } = null!;

    public long NotaEvaluacion { get; set; }

    public string CodEvaluacion { get; set; } = null!;

    public virtual EvaCatEvaluacion CodEvaluacionNavigation { get; set; } = null!;
}
