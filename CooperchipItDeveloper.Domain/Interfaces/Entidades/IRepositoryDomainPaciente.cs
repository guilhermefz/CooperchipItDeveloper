using Cooperchip.ItDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperchipItDeveloper.Domain.Interfaces.Entidades
{
    public interface IRepositoryDomainPaciente : IDomainGenericRepository<Paciente, Guid>
    {
        Task<IEnumerable<Paciente>> ListaPacientesComEstado();
        Task<IEnumerable<Paciente>> ListaPacientes();

    }
}
