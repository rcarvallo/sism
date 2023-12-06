using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sism.Models;

namespace sismActual.Controllers
{
    public class IngresoDiarioController : Controller
    {

        private readonly CermetpesajeContext _context;


        public IngresoDiarioController(CermetpesajeContext context)
        {
            _context = context;
        }

        // GET: IngresoDiario
        public IActionResult Index()
        {
            var fechaInicio = DateTime.Now.Date;
            var consulta = (from p in _context.Consultaclientes
                            where p.FechaYhoraEntrada.Value.Date == fechaInicio.Date
                            orderby p.FechaYhoraEntrada descending
                            select p);


            return View(consulta);
        }
      

        // GET: IngresoDiario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Consultaclientes == null)
            {
                return NotFound();
            }

            var consultaclientes = await _context.Consultaclientes
                .FirstOrDefaultAsync(m => m.PesNum == id);
            if (consultaclientes == null)
            {
                return NotFound();
            }

            return View(consultaclientes);
        }

        private bool ClienteExists(int id)
        {
            return (_context.Consultaclientes?.Any(e => e.PesNum == id)).GetValueOrDefault();
        }


    }
}
