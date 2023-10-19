using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace sismActual.Controllers
{
    public class DqoController : Controller
    {
        private readonly ParshallContext _context;


        public DqoController(ParshallContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Dqo>> resumenDqo()
        {
            var fechaInicio =DateTime.Now.Date.AddDays(-6);

            var resumen = await _context.Dqos
                .Where(dqo => dqo.Hora.Value.Date >= fechaInicio.Date)
                .GroupBy(dqo => dqo.Hora.Value.Date)
                .Select(d => new Dqo
                {
                    Hora = d.Key.Date,
                    Valor = d.Average(d => d.Valor),

                }).ToListAsync();

            return resumen;
        }

       
        public async Task<IEnumerable<Dqo>> resumenDqohora()
        {
            
            var horaInicio = DateTime.Now.Date.AddHours(-5);
            var resumenHora = await  _context.Dqos
                              .Where(dqo => dqo.Hora >= horaInicio)
                              .GroupBy(dqo => dqo.Hora) 
                              .Select (c => new Dqo
                              {
                                  Hora = c.Key,
                                  Valor = c.Average(c => c.Valor),

                              }).ToListAsync();

            return resumenHora;
        }

        // GET: DqoController
        public ActionResult Index()
        {
            var dqoLista = (from t in _context.Dqos
                            where t != null
                            orderby t.Hora descending
                            select t).Take(100);

            return View(dqoLista);
        }

  

    }
}
