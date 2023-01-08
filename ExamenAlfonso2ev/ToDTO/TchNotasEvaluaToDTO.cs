using ExamenAlfonso2ev.DTOS;
using ExamenAlfonso2evDAL.DAO;
using Microsoft.VisualBasic;

namespace ExamenAlfonso2ev.ToDTO
{
    public class TchNotasEvaluaToDTO
    {
        public static TchNotasEvaluDTO UsarToDTO(EvaTchNotasEvaluacion daoTch)
        {
            Console.WriteLine("[INFORMACION]: Entrando en el metodo to DTO");
            return new TchNotasEvaluDTO(
                daoTch.MdUuid,
                daoTch.MdFch,
                daoTch.IdNotaEvaluacion,
                daoTch.CodAlumno,
                daoTch.NotaEvaluacion,
                daoTch.CodEvaluacion,
                daoTch.CodEvaluacionNavigation
                );
        }
    }
}
