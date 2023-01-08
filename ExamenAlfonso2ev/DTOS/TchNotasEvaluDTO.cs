using ExamenAlfonso2evDAL.DAO;
using Microsoft.AspNetCore.Mvc;

namespace ExamenAlfonso2ev.DTOS
{
    public class TchNotasEvaluDTO
    {
        public TchNotasEvaluDTO(string? mdUuid, DateTime? mdFch, int idNotaEvaluacion, string codAlumno, long notaEvaluacion, string codEvaluacion)
        {
            MdUuid = mdUuid;
            MdFch = mdFch;
            IdNotaEvaluacion = idNotaEvaluacion;
            CodAlumno = codAlumno;
            NotaEvaluacion = notaEvaluacion;
            CodEvaluacion = codEvaluacion;
        }

        public TchNotasEvaluDTO(string? mdUuid, DateTime? mdFch, int idNotaEvaluacion, string codAlumno, long notaEvaluacion, string codEvaluacion, EvaCatEvaluacion codEvaluacionNavigation)
        {
            MdUuid = mdUuid;
            MdFch = mdFch;
            IdNotaEvaluacion = idNotaEvaluacion;
            CodAlumno = codAlumno;
            NotaEvaluacion = notaEvaluacion;
            CodEvaluacion = codEvaluacion;
            CodEvaluacionNavigation = codEvaluacionNavigation;
        }

        public string? MdUuid { get; set; }

        public DateTime? MdFch { get; set; }

        public int IdNotaEvaluacion { get; set; }

        public string CodAlumno { get; set; } = null!;

        public long NotaEvaluacion { get; set; }

        public string CodEvaluacion { get; set; } = null!;

        public virtual EvaCatEvaluacion CodEvaluacionNavigation { get; set; } = null!;
        
    }
}
