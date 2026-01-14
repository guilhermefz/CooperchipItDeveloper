using CooperchipItDeveloper.Domain.Mensageria;
using Microsoft.AspNetCore.Mvc;

namespace CooperchipItDeveloper.Mvc.Extensions.ViewComponents.Summary
{
    [ViewComponent(Name = "summary")]
    public class SummaryViewComponent : ViewComponent
    {
        private readonly INotification _notification;

        public SummaryViewComponent(INotification notification) => _notification = notification;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notifications = await Task.FromResult(_notification.ObterNotificacacoes());

            notifications.ForEach(n => ViewData.ModelState.AddModelError(string.Empty, n.Mensagem));

            return View(await Task.FromResult(notifications));
        }
    }
}
