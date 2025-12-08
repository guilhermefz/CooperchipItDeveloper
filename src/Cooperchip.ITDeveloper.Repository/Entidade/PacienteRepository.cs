using Cooperchip.ItDeveloper.Data.Data.ORM;
using Cooperchip.ItDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Repository.Base;
using CooperchipItDeveloper.Domain.Interfaces.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Repository.Entidade
{
    public class PacienteRepository : RepositoryGeneric<Paciente, Guid>, IRepositoryDomainPaciente
    {
        private readonly ITDeveloperDbContext _context;

        public PacienteRepository(ITDeveloperDbContext context) : base (context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<Paciente>> ListaPacientes()
        {
            return await _context.Paciente.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Paciente>> ListaPacientesComEstado()
        {
            return await _context.Paciente.Include(e => e.EstadoPaciente).AsNoTracking().ToListAsync();
        }

        public async Task<List<EstadoPaciente>> ListarEstadoPaciente()
        {
            return await _context.EstadoPaciente.AsNoTracking().ToListAsync();
        }

        public async Task<Paciente> ObterPacienteComEstadoPaciente(Guid pacienteId)
        {
            return await _context.Paciente.Include(e => e.EstadoPaciente).AsNoTracking().FirstOrDefaultAsync(x => x.Id == pacienteId);
        }

        public async Task<IEnumerable<Paciente>> ObterPacientesPorEstadoPaciente(Guid estadoPacienteId)
        {
            var lista = await _context.Paciente
                .Include(ep => ep.EstadoPaciente)
                .AsNoTracking()
                .Where(x => x.EstadoPaciente.Id == estadoPacienteId)
                .OrderBy(o => o.Nome)
                .ToListAsync();

            return lista;
        }

        public bool TemPaciente(Guid pacienteId)
        {
            return _context.Paciente.Any(p => p.Id == pacienteId);
        }

        public async Task<Paciente> PacienteDetalhe(Guid id)
        {
            return await _context.Paciente.Include(x => x.EstadoPaciente).AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Paciente>> BuscarPacientesPorEstadoAsync(Guid estadoPacienteId)
        {
            return await _context.Paciente.Include(x => x.EstadoPaciente)
                .AsNoTracking()
                .Where(x => x.EstadoPaciente.Id == estadoPacienteId)
                .OrderBy(OrderedParallelQuery => OrderedParallelQuery.Nome)
                .ToListAsync();
        }
    }
}
