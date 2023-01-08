using ExamenAlfonso2ev.Consultas;
using ExamenAlfonso2ev.DTOS;
using ExamenAlfonso2evDAL.DAO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamenAlfonso2ev.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }
        
        public IActionResult OnPostRegEvaluacion(string nombreAlumno, int notaAlumno, string evaluacion)
        {
            Console.WriteLine("[INFORMACION]: Entrando en el metodo OnPostRegEvaluacion");
            BdEvaluacionContext db = new BdEvaluacionContext();
            Random rand = new Random();
            var idnotaEvalu = rand.Next(1, 101);
            Guid uuid = Guid.NewGuid();
            InertaDto insertaDto = new InertaDto();
            Console.WriteLine("[INFORMACION]: Creando el DTO en base a los valores introducidos");
            TchNotasEvaluDTO notasEvalua = new TchNotasEvaluDTO
            (
                uuid.ToString(),
                DateTime.Now,
                idnotaEvalu,
                nombreAlumno,
                notaAlumno,
                evaluacion
            );
            insertaDto.insertar(db,notasEvalua);
            Console.WriteLine("[INFORMACION]: Saliendo del metodo insertar");
            return RedirectToPage("Index");      
        }
    }
}