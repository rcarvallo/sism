using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using sismActual.Services;

namespace sismActual.Controllers
{
    public class ParshallDiarioController : Controller
    {
        private readonly AveragePerDayService _averagePerDayService;

        public ParshallDiarioController(AveragePerDayService averagePerDayService)
        {
            _averagePerDayService = averagePerDayService;
        }


        public async Task<IActionResult> Index()
        {
            try
            {
                var last10DaysResults = await _averagePerDayService.GetAveragePerDayAsync();
                var orderedResults = last10DaysResults.OrderByDescending(result => result.Dia).Take(10).ToList();
                return View(orderedResults);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it in a way that makes sense for your application
                // You might want to display a user-friendly error view.
                return View("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
}
