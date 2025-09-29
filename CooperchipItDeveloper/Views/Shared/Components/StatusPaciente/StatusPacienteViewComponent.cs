using Cooperchip.ItDeveloper.Mvc.Extensions.ViewComponents.Helpers;
using Cooperchip.ItDeveloper.Mvc.Services;
using CooperchipItDeveloper.Mvc.Extensions.ViewComponents;
using CooperchipItDeveloper.Mvc.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;

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
            string corProgress = "";
            if (estado == "Grave")
                card = "card card-stat p-3 bg-red";
            if (estado == "Crítico")
                card = "card card-stat p-3 bg-yellow";
            if (estado == "Em Observação")
                card = "card card-stat p-3 bg-blue";
            if (estado == "Estável")
                card = "card card-stat p-3 bg-write";
            
            var percentual = _estadoPacienteService.ObterProgresso(estado);
            int quantidade = await _estadoPacienteService.ContarPacientesPorEstado(estado);
            var model = new StatusPacienteViewModel
            {
                Percentual = percentual,
                Quantidade = quantidade,
                Descricao = estado,
                ClassContainer = card,
                Progress = corProgress
            };

            return View(model);
        }
    }
}
