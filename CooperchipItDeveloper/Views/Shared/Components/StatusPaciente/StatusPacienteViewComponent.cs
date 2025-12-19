using CooperchipItDeveloper.Mvc.Extensions.ViewComponents;
using CooperchipItDeveloper.Mvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace CooperchipItDeveloper.Mvc.Views.Shared.Components.StatusPaciente
{
    public class StatusPacienteViewComponent: ViewComponent
    {
        private readonly EstadoPacienteService _estadoPacienteService;

        public StatusPacienteViewComponent(EstadoPacienteService estadoPacienteService)
        {
            _estadoPacienteService = estadoPacienteService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string estado)
        {
            string card = "";
            string iconLg = "";
            if (estado == "Grave")
                card = "card card-stat p-3 bg-red";
                iconLg = "bi bi-8-circle-fill";
            if (estado == "Crítico")
                card = "card card-stat p-3 bg-yellow";
            iconLg = "bi bi-arrow-down-circle-fill";
            if (estado == "Em Observação")
                card = "card card-stat p-3 bg-blue";
            iconLg = "bi bi-award-fill";
            if (estado == "Estável")
                card = "card card-stat p-3 bg-write";
                iconLg = "bi bi-bag";


            var percentual = _estadoPacienteService.ObterProgresso(estado);
            int quantidade = await _estadoPacienteService.ContarPacientesPorEstado(estado);
            var model = new StatusPacienteViewModel
            {
                Percentual = percentual,
                Quantidade = quantidade,
                Descricao = estado,
                ClassContainer = card,
                IconeLg = iconLg
            };

            return View(model);
        }
    }
}
