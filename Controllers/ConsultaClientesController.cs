using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NuGet.Protocol.Core.Types;
using Pomelo.EntityFrameworkCore.MySql.Query.Internal;
using sism.Models;

namespace sism.Controllers
{

    public class ConsultaClientesController : Controller
    {

        private readonly CermetpesajeContext _context;

        
        public ConsultaClientesController(CermetpesajeContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Consultacliente>> resumenClientes()
        {

            var fechaInicio = DateTime.Now.Date.AddDays(-6);
            var clientes = await _context.Consultaclientes
              .Where(dqo => dqo.FechaYhoraEntrada.Value.Date >= fechaInicio.Date)
                .GroupBy(dqo => dqo.FechaYhoraEntrada.Value.Date)
               .Select(d => new Consultacliente
               {
                   FechaYhoraEntrada = d.Key,
                   PesTon = d.Sum(d=> d.PesTon)

               }).ToListAsync();

            return clientes;
        }

        // GET: ConsultaClientes
        public IActionResult Index()
        {

            var consulta = (from p in _context.Consultaclientes
                            where p.FiltroSistema == "TRANSFERENCIA"
                            where p.Estado == 1
                            orderby p.PesPermanencia descending
                            select p).Take(500);


            return View(consulta);
        }

        // GET: Clientes/Details/5
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
