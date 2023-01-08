using ExamenAlfonso2ev.DTOS;
using ExamenAlfonso2evDAL.DAO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamenAlfonso2ev.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public BdEvaluacionContext db = new BdEvaluacionContext();
        
        //Obtengo los valores del formulario
        [BindProperty]
        public string codAlumno { get; set; }
        [BindProperty]
        public string codEvalu { get; set; }
        public void OnPostCodAlumno()
        {
            try 
            {
                Console.WriteLine("[INFORMACION]: Entrando en el metodo OnPostCodAlumno");
                var alumn = db.EvaTchNotasEvaluacions.Where(e => e.CodAlumno == codAlumno).FirstOrDefault();

                //Hacemos un DAO to DTO
                TchNotasEvaluDTO alumNotas = ExamenAlfonso2ev.ToDTO.TchNotasEvaluaToDTO.UsarToDTO(alumn);
                Console.WriteLine("[INFORMACION]: Saliendo del metodo to DTO");

                ViewData["INFORMACION"] = " ";

                if (alumNotas != null)
                {
                    ViewData["AlumnoCodAlum"] = alumNotas;
                }
                else
                {
                    ViewData["INFORMACION"] = "[ERROR]: ¡El usuario elegido no existe!";
                }
            }
            catch(Exception ex) { Console.WriteLine("Error en OnPostCodAlumno: " + ex.Message); }
            
        }

        public void OnPostCodEvalu()
        {
            try
            {
                Console.WriteLine("[INFORMACION]: Entrando en el metodo OnPostCodEvalu");
                var alumn = db.EvaTchNotasEvaluacions.Where(e => e.CodEvaluacion == codEvalu).FirstOrDefault();
                Console.WriteLine("[INFORMACION]: Saliendo del metodo to DTO");

                //Hacemos un DAO to DTO
                TchNotasEvaluDTO alumNotas = ExamenAlfonso2ev.ToDTO.TchNotasEvaluaToDTO.UsarToDTO(alumn);

                ViewData["INFORMACION"] = " ";

                if (alumNotas != null)
                {
                    ViewData["AlumnoCodEv"] = alumNotas;
                }
                else
                {
                    ViewData["INFORMACION"] = "[ERROR]: ¡El usuario elegido no existe!";
                }
            }
            catch (Exception ex) { Console.WriteLine("Error en OnPostCodEvalu: " + ex.Message); }
        }
    }
}