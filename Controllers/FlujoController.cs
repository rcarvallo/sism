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
