using ExamenAlfonso2ev.DTOS;
using ExamenAlfonso2evDAL.DAO;

namespace ExamenAlfonso2ev.Consultas
{
    public class InertaDto
    {
        
        public void insertar(BdEvaluacionContext db, TchNotasEvaluDTO notasEvalua) {
            Console.WriteLine("[INFORMACION]: Entrando en el metodo insertar");
            try
            {
                EvaTchNotasEvaluacion notasEvaluacion = new EvaTchNotasEvaluacion();
                notasEvaluacion = ExamenAlfonso2ev.ToDAO.TchNotasEvaluaToDAO.UsarToDAO(notasEvalua);
                db.EvaTchNotasEvaluacions.Add(notasEvaluacion);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error en insert: " + ex.Message);
            }
            
        }

      
        
    }
}
