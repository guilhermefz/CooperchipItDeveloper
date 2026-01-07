using Cooperchip.ItDeveloper.Domain.Entities;
using Cooperchip.ItDeveloper.Domain.Enuns;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cooperchip.ITDeveloper.Application.Areas.Pacientes.Models
{
    public class PacienteFormModel
    {
        public Guid Id { get; set; }

        [DisplayName("Estado do paciente")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Guid? EstadoPacienteId { get; set; }

        [Display(Name = "Estado do Paciente")]
        public virtual EstadoPaciente? EstadoPaciente { get; set; }

        public IEnumerable<SelectListItem>? EstadosPaciente { get; set; }

        [DisplayName(displayName: "Nome do Paciente")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(maximumLength: 80, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string? Nome { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date, ErrorMessage = "o campo {0} está inválido")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public DateTime? DataNascimento { get; set; }

        [Display(Name = "Data de Internação")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DataType(DataType.DateTime, ErrorMessage = "o campo {0} está inválido")]
        public DateTime? DataInternacao { get; set; }

        [DisplayName("Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email Inválido")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string? Email { get; set; }

        public bool Ativo { get; set; }

        [DisplayName("CPF")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(11, ErrorMessage = "O campo {0} tem de ter {1} caracteres", MinimumLength = 11)]
        public string? Cpf { get; set; }

        [DisplayName("Tipo de Paciente")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public TipoPaciente? TipoPaciente { get; set; }

        [DisplayName("Sexo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Sexo? Sexo { get; set; }

        [DisplayName("RG")]
        [MaxLength(15, ErrorMessage = "O campo {0} não pode ter mais que (1) caracteres. ")]
        public string? Rg { get; set; }

        [DisplayName("Orgão do RG")]
        public string? RgOrgao { get; set; }

        [Display(Name = "Data de Emissão da RG")]
        [DataType(DataType.DateTime, ErrorMessage = "o campo {0} está inválido")]
        public DateTime? RgDataEmissao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string? Motivo { get; set; }
    }
}
