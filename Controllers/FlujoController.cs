using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pomelo.EntityFrameworkCore.MySql.Query.Internal;
using sism.Models;

namespace sismActual.Controllers
{
    public class FlujoController : Controller
    {
        private readonly ParshallContext _context;


        public FlujoController(ParshallContext context)
        {
            _context = context;
        }

        public IActionResult resumenFlujo()
        {
            DateTime FechaInicio = DateTime.Now;
            FechaInicio = FechaInicio.AddDays(-6);


            List<Flujo> ListaFlujo = (from d in _context.Flujos
                               where d.Hora.Value.Date >= FechaInicio.Date
                               group d by d.Hora.Value.Date into grupo
                               select new Flujo
                               {
                                   Hora = grupo.Key,
                                   Valor = grupo.Average(d => d.Valor)
                               }).ToList();

            return StatusCode(StatusCodes.Status200OK, ListaFlujo);
        }

             
        public async Task<IEnumerable<Flujo>> resumenFlujoHora()
        {
            
            var horaInicio = DateTime.Now.Date.AddHours(-5);
            var resumenFlujo = await  _context.Flujos
                              .Where(flujo => flujo.Hora >= horaInicio)
                              .GroupBy(flujo => flujo.Hora) 
                              .Select (c => new Flujo
                              {
                                  Hora = c.Key,
                                  Valor = c.Average(c => c.Valor),

                              }).ToListAsync();

            return resumenFlujo;
        }
        // GET: DqoController
        public ActionResult Index()
        {
            var flujoLista = (from a in _context.Flujos
                            where a != null
                            orderby a.Hora descending
                            select a).Take(100);

            return View(flujoLista);
        }


    }
}
