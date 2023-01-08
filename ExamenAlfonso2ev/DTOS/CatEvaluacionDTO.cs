using ExamenAlfonso2evDAL.DAO;

namespace ExamenAlfonso2ev.DTOS
{
    public class CatEvaluacionDTO
    {
        public string CodEvaluacion { get; set; } = null!;

        public string DescEvaluacion { get; set; } = null!;

        public virtual ICollection<EvaTchNotasEvaluacion> EvaTchNotasEvaluacions { get; } = new List<EvaTchNotasEvaluacion>();
    }
}
