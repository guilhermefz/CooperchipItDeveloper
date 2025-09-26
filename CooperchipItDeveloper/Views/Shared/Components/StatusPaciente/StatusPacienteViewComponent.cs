using Cooperchip.ItDeveloper.Mvc.Services;
using CooperchipItDeveloper.Mvc.Extensions.ViewComponents;
using Microsoft.AspNetCore.Mvc;

namespace CooperchipItDeveloper.Mvc.Views.Shared.Components.StatusPaciente
{
    public class StatusPacienteViewComponent: ViewComponent
    {
        private readonly PacienteService _pacienteService;

        public StatusPacienteViewComponent(PacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            int pacientesGrave = await _pacienteService.ContarPacientesPorEstado("Grave");
            var model = new StatusPacienteViewModel
            {
                Quantidade = pacientesGrave,
                Descricao = "Grave"
            };

            return View(model);
        }
    }
}
