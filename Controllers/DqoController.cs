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
    public class DqoController : Controller
    {
        private readonly ParshallContext _context;


        public DqoController(ParshallContext context)
        {
            _context = context;
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
