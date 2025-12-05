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
    }
}
