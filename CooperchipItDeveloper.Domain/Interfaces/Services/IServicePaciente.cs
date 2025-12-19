using Cooperchip.ItDeveloper.Domain.Entities;

namespace CooperchipItDeveloper.Domain.Interfaces.Services
{
    public interface IServicePaciente
    {
        Task SalvarPacienteAsync(Paciente paciente);

        Task<List<Paciente>> BuscarPacientesAsync();

        Task<Paciente> BuscarPacientePorIdAsync(Guid id);

        Task<List<Paciente>> BuscarPacientesPorEstadoAsync(Guid estadoPacienteId);

        Task<Paciente> PacienteDetalhe(Guid id);

        bool TemPaciente(Guid pacienteId);

        Task<List<EstadoPaciente>> ListarEstadoPaciente();

        Task Editar(Paciente paciente);

        Task Deletar(Paciente paciente);

        Task<IEnumerable<Paciente>> ListaPacientesComEstado();

        Task<IEnumerable<Paciente>> ListaPacientes();

        Task<List<EstadoPaciente>> ListarEstadoDePaciente();

        Task<Paciente> ObterPacienteComEstadoPaciente(Guid pacienteId);

        Task<IEnumerable<Paciente>> ObterPacientesPorEstadoPaciente(Guid id);
    }
}
