using Cooperchip.ItDeveloper.Domain.Entities.Base;
using FluentValidation;
using FluentValidation.Results;

namespace CooperchipItDeveloper.Domain.Mensageria
{
    public abstract class BaseService
    {
        private readonly INotification _notification;

        protected BaseService(INotification notification)
        {
            _notification = notification;
        }

        protected void Notificar(ValidationResult validation)
        {
            foreach (var erro in validation.Errors)
            {
                Notificar(erro.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            _notification.Handle(new Notificacao(mensagem));
        }

        protected bool ExecutarValidacao<TVal, T>(TVal validacao, T entidade) where TVal : AbstractValidator<T>
        {
            var validator = validacao.Validate(entidade);
            if (validator.IsValid) return true;

            Notificar(validator);
            return false;
        }
    }
}
