using CooperchipItDeveloper.Domain.Mensageria;
using Microsoft.AspNetCore.Mvc;

namespace CooperchipItDeveloper.Mvc.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly INotification _notification;

        protected BaseController(INotification notification)
        {
            _notification = notification;
        }

        protected bool OperacaoValida()
        {
            return !_notification.TemNotificacao();
        }
    }
}
