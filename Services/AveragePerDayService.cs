// Example service class
using Microsoft.EntityFrameworkCore;
using sism.Models;
using System.Linq;
using System.Threading.Tasks;

namespace sismActual.Services
{
    public class AveragePerDayService
    {
        private readonly ParshallContext _context;

        public AveragePerDayService(ParshallContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<AverageResult>> GetAveragePerDayAsync()
        {
            var twoDaysAgo = DateTime.Now.Date.AddDays(-9);

            var flujosValues = await _context.Flujos
                .Where(flujo => flujo.Hora.Value.Date >= twoDaysAgo)
                .ToListAsync();

            var averages = await _context.Dqos
                .Where(dqo => dqo.Hora.Value.Date >= twoDaysAgo)
                .GroupBy(dqo => dqo.Hora.Value.Date)
                .Select(g => new AverageResult
                {
                    Dia = g.Key,
                    PromedioDQO = g.Average(dqo => (double)dqo.Valor),
                    PromedioFlujo = CalculateAverageFlujo(flujosValues, g.Key)
                })
                .ToListAsync();

            return averages;
        }

        private static double CalculateAverageFlujo(List<Flujo> flujosValues, DateTime key)
        {
            var values = flujosValues
                .Where(flujo => flujo.Hora.Value.Date == key)
                .Select(flujo => flujo.Valor)
                .ToArray();

            return values.Any() ? values.Average() : 0.0;
        }



    }
}
