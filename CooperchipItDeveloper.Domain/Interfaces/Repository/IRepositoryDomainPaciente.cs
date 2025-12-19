using Cooperchip.ItDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperchipItDeveloper.Domain.Interfaces.Repository
{
    public interface IRepositoryDomainPaciente : IDomainGenericRepository<Paciente, Guid>
    {
        Task<IEnumerable<Paciente>> ListaPacientesComEstado();
        Task<IEnumerable<Paciente>> ListaPacientes();
        Task<List<EstadoPaciente>> ListarEstadoPaciente();
        Task<Paciente> ObterPacienteComEstadoPaciente(Guid pacienteId);
        bool TemPaciente(Guid pacienteId);
        Task<IEnumerable<Paciente>> ObterPacientesPorEstadoPaciente(Guid estadoPacienteId);
        Task<Paciente> PacienteDetalhe(Guid id);
        Task<List<Paciente>> BuscarPacientesPorEstadoAsync(Guid estadoPacienteId);
    }
}
