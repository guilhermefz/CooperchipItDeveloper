using Cooperchip.ITDeveloper.Application.Areas.Pacientes.Models;
using FluentValidation;

namespace Cooperchip.ITDeveloper.Application.Areas.Pacientes.Validators
{
    public class PacienteValidator : AbstractValidator<PacienteFormModel>
    {
        public PacienteValidator() 
        {
            RuleFor(x => x.Nome)
                .NotEmpty().NotNull().WithMessage("O campo Nome é obrigatório.")
                .Length(3, 80).WithMessage("O campo Nome deve ter entre {MinLength} e {Maxlength} caracteres.");

            RuleFor(x => x.Cpf)
                .NotEmpty().NotNull().WithMessage("O campo CPF é obrigatório.")
                .Length(11,11).WithMessage("O campo CPF deve conter 11 caracteres.");

            RuleFor(x => x.DataNascimento)
                .NotEmpty().NotNull().WithMessage("O campo Data de Nascimento é obrigatório.");

            RuleFor(x => x.DataNascimento)
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("O campo Data de Nascimento não pode ser registrado no futuro.");

            RuleFor(x => x.DataNascimento)
                .LessThan(DateTime.Now.AddYears(150))
                .WithMessage("O campo Data de Nascimento não pode ser maior que 150 anos.");

            RuleFor(m => m.Motivo)
                .MaximumLength(30).WithMessage("O campo Motivo não pode ter mais que {MaxLength} caracteres.");

            RuleFor(ep => ep.EstadoPacienteId)
                .NotNull().WithMessage("O campo Estado do Paciente não pode ser nulo.");

            RuleFor(ep => ep.EstadoPacienteId)
                .NotEmpty().WithMessage("O campo Estado do Paciente precisa ser informado.");
        }
    }
}
