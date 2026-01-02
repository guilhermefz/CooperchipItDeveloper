using Cooperchip.ItDeveloper.Domain.Entities;
using Cooperchip.ItDeveloper.Domain.Enuns;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cooperchip.ITDeveloper.Application.Areas.Pacientes.Models
{
    public class PacienteGridModel
    {
        [DisplayName("Id do Paciente")]
        public Guid Id { get; set; }

        [DisplayName("Estado do paciente")]
        public Guid? EstadoPacienteId { get; set; }

        [Display(Name = "Estado do Paciente")]
        public virtual EstadoPaciente? EstadoPaciente { get; set; }

        [DisplayName(displayName: "Nome do Paciente")]
        public string? Nome { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Data de Internação")]
        public DateTime DataInternacao { get; set; }

        [DisplayName("Email")]
        public string? Email { get; set; }

        [DisplayName("CPF")]
        public string? Cpf { get; set; }

        [DisplayName("Sexo")]
        public Sexo? Sexo { get; set; }
        
    }
}
