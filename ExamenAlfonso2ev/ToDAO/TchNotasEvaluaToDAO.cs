using ExamenAlfonso2ev.DTOS;
using ExamenAlfonso2evDAL.DAO;
using System.Text.RegularExpressions;

namespace ExamenAlfonso2ev.ToDAO
{
    public class TchNotasEvaluaToDAO
    {
        public static EvaTchNotasEvaluacion UsarToDAO(TchNotasEvaluDTO dtotch)
        {
            Console.WriteLine("[INFORMACION]: Entrando en el metodo to DAO");
            return new EvaTchNotasEvaluacion
            {
                MdUuid = dtotch.MdUuid,
                MdFch = dtotch.MdFch,
                IdNotaEvaluacion = dtotch.IdNotaEvaluacion,
                CodAlumno = dtotch.CodAlumno,
                NotaEvaluacion = dtotch.NotaEvaluacion,
                CodEvaluacion = dtotch.CodEvaluacion,
                CodEvaluacionNavigation = dtotch.CodEvaluacionNavigation
            };
        }
    }
}
