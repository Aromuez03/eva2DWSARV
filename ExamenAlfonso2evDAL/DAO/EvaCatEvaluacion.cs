using System;
using System.Collections.Generic;

namespace ExamenAlfonso2evDAL.DAO;

public partial class EvaCatEvaluacion
{

    /// <summary>
    /// PR - Primera Evaluación, SG - Segunda Evaluación, TC - Tercera Evaluación
    /// </summary>
    public string CodEvaluacion { get; set; } = null!;

    public string DescEvaluacion { get; set; } = null!;

    public virtual ICollection<EvaTchNotasEvaluacion> EvaTchNotasEvaluacions { get; } = new List<EvaTchNotasEvaluacion>();
}
