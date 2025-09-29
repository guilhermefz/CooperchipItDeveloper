using Cooperchip.ItDeveloper.Data.Data.ORM;
using Cooperchip.ItDeveloper.Mvc.Extensions.ViewComponents.Helpers;
using Microsoft.EntityFrameworkCore;

namespace CooperchipItDeveloper.Mvc.Services
{
    public class EstadoPacienteService
    {
        private readonly ITDeveloperDbContext _context;
        public EstadoPacienteService(ITDeveloperDbContext context) 
        {
            _context = context;
        }



        public async Task<int> ContarPacientesPorEstado(string descricaoEstado)
        {
            var estado = await _context.EstadoPaciente
                .FirstOrDefaultAsync(e => e.Descricao == descricaoEstado);
            if (estado is null)
            {
                return 0;
            }
            return await _context.Paciente
                .Where(p => p.EstadoPacienteId == estado.Id)
                .CountAsync();
        }

        public int ObterTotal()
        {
            var totalGeral = Util.TotReg(_context);
            return totalGeral;
        }

        public decimal ObterProgresso(string estado)
        {
            var totalEstado = Util.GetNumRegEstado(_context, estado);
            var totGeral = ObterTotal();
            decimal progress = (totGeral > 0) ? totalEstado * 100 / totGeral : 0;
            return progress;
        }
    }
}
