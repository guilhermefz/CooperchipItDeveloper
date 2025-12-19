using AutoMapper;
using Cooperchip.ItDeveloper.Domain.Entities;
using CooperchipItDeveloper.Domain.Interfaces.Repository;
using CooperchipItDeveloper.Domain.Interfaces.Services;

namespace Cooperchip.ItDeveloper.Mvc.Services
{
    public class PacienteService : IServicePaciente
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryDomainPaciente _repositoryPaciente;

        public PacienteService(IMapper mapper, IRepositoryDomainPaciente repositoryPaciente)
        {
            _mapper = mapper;
            _repositoryPaciente = repositoryPaciente;
        }

        public async Task SalvarPacienteAsync(Paciente paciente)
        {
            await _repositoryPaciente.Inserir(paciente);
        }

        public async Task<List<Paciente>> BuscarPacientesAsync()
        {
            var paciente =  await _repositoryPaciente.ListaPacientesComEstado();
            return paciente.ToList();
        }

        public async Task<Paciente> BuscarPacientePorIdAsync(Guid id)
        {
            return await _repositoryPaciente.SelecionarPorId(id);
        }

        public async Task<List<Paciente>> BuscarPacientesPorEstadoAsync(Guid estadoPacienteId)
        {
            var pacientes = await _repositoryPaciente.BuscarPacientesPorEstadoAsync(estadoPacienteId);
            List<Paciente> listModel = new();

            foreach (var item in pacientes)
            {
                listModel.Add(item);
            }
            return listModel;
        }

        public async Task<Paciente> PacienteDetalhe(Guid id)
        {
            var paciente = await _repositoryPaciente.PacienteDetalhe(id);
            var Model = _mapper.Map<Paciente>(paciente);

            return Model;
        }
        public bool TemPaciente(Guid pacienteId)
        {
            return _repositoryPaciente.TemPaciente(pacienteId);
        }

        public async Task<List<EstadoPaciente>> ListarEstadoPaciente()
        {
            return await _repositoryPaciente.ListarEstadoPaciente();
        }

        public async Task Editar(Paciente paciente)
        {
            await _repositoryPaciente.Atualizar(paciente);
        }

        public async Task Deletar(Paciente paciente)
        {
            await _repositoryPaciente.Excluir(paciente);
        }

        public Task<IEnumerable<Paciente>> ListaPacientesComEstado()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Paciente>> ListaPacientes()
        {
            throw new NotImplementedException();
        }

        public async Task<List<EstadoPaciente>> ListarEstadoDePaciente()
        {
            return await _repositoryPaciente.ListarEstadoPaciente();
        }

        public async Task<Paciente> ObterPacienteComEstadoPaciente(Guid pacienteId)
        {
            return await _repositoryPaciente.ObterPacienteComEstadoPaciente(pacienteId);
        }

        public async Task<IEnumerable<Paciente>> ObterPacientesPorEstadoPaciente(Guid id)
        {
            return await _repositoryPaciente.ObterPacientesPorEstadoPaciente(id);
        }
    }
}
