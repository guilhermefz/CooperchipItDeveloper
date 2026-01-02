using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Cooperchip.ItDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Application.Areas.Pacientes.Interfaces;
using Cooperchip.ITDeveloper.Application.Areas.Pacientes.Models;
using Cooperchip.ITDeveloper.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Cooperchip.ItDeveloper.Mvc.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IServicePaciente _pacienteService;
        private readonly IMapper _mapper;
        private readonly INotyfService _notyf;
        private readonly ILogger<PacienteController> _logger;

        public PacienteController(IServicePaciente pacienteService, IMapper mapper, INotyfService notyf, ILogger<PacienteController> logger)
        {
            _pacienteService = pacienteService;
            _mapper = mapper;
            _notyf = notyf;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var Model = await _pacienteService.PacienteDetalhe(id);
            var viewModel = _mapper.Map<PacienteViewModel>(Model);
            return PartialView("_Details", viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetPacienteAsync(Guid id)
        {
            var paciente = await _pacienteService.BuscarPacientePorIdAsync(id);
            return View(paciente);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var paciente = new PacienteFormModel
            {
                EstadosPaciente = (await _pacienteService.ListarEstadoPaciente())
                          .Select(e => new SelectListItem
                          {
                              Value = e.Id.ToString(),
                              Text = e.Descricao
                          })
                          .ToList()
            };
            return await Task.FromResult(View(paciente));
        }


        [HttpPost]
        public async Task<IActionResult> Create(PacienteFormModel model)
        {
            
            if (ModelState.IsValid)
            {

                var paciente = _mapper.Map<Paciente>(model);
                
                try
                {
                    await _pacienteService.SalvarPacienteAsync(paciente);
                    return Redirect(nameof(Index));
                }
                catch (Exception ex)
                {
                    return View(model);
                }
            }
            model = new PacienteFormModel
            {
                EstadosPaciente = (await _pacienteService.ListarEstadoPaciente())
                          .Select(e => new SelectListItem
                          {
                              Value = e.Id.ToString(),
                              Text = e.Descricao
                          })
                          .ToList()
            };
            _notyf.Error("Ocorreu um erro ao salvar, verifique se os campos foram escritos corretamente!");
            //ViewBag.EstadoPaciente = new SelectList(await _pacienteService.ListarEstadoPaciente(), "Id", "Descricao");
            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> ObterPacientesPorEstadoPaciente(Guid id)
        {
            var pacientes = await _pacienteService.BuscarPacientesPorEstadoAsync(id);
            var viewModel = _mapper.Map<List<PacienteViewModel>>(pacientes);
            return View(pacientes);
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            _logger.LogError("Teste de log Serilog(Seq) - A tela inicial de pacientes foi aberta.");
            var pacientes = await _pacienteService.BuscarPacientesAsync();
            List<PacienteGridModel> list = new();

            foreach ( var item in pacientes)
            {
                list.Add (_mapper.Map<PacienteGridModel>(item));
            }
            return View(list);    
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            Paciente paciente = await _pacienteService.BuscarPacientePorIdAsync(id);
            if(paciente is null)
            {
                return NotFound();
            }

            ViewBag.EstadoPaciente = new SelectList(await _pacienteService.ListarEstadoPaciente(), "Id", "Descricao");
            var viewModel = _mapper.Map<PacienteViewModel>(paciente);

            viewModel.EstadosPaciente = (await _pacienteService.ListarEstadoPaciente())
                          .Select(e => new SelectListItem
                          {
                              Value = e.Id.ToString(),
                              Text = e.Descricao
                          })
                          .ToList();

            return await Task.FromResult(View(viewModel));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, PacienteViewModel model)
        {
            if (model.Id != id)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                try
                {
                    var paciente = _mapper.Map<Paciente>(model);
                    await _pacienteService.Editar(paciente);
                    TempData["Sucesso"] = "Registro Cadastrado com Sucesso!"; 
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_pacienteService.TemPaciente(model.Id))
                    {
                        return NotFound();
                    }
                    else {
                        throw;
                    }
                } catch (Exception ex) {
                    return BadRequest(ex.Message);
                }
            }
            ViewBag.EstadoPaciente = new SelectList(await _pacienteService.ListarEstadoPaciente(), "Id", "Descricao");
            return View(model);
                    

        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            Paciente paciente = await _pacienteService.BuscarPacientePorIdAsync(id);
            var viewModel = _mapper.Map<PacienteViewModel>(paciente);
            if (paciente is null)
            {
                return NotFound();
            }
            return View(viewModel);
        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            Paciente paciente = await _pacienteService.BuscarPacientePorIdAsync(id);
            if(paciente is null)
            {
                TempData["Error"] = "Erro ao tentar excluir registro";
                return NotFound();
            }

            await _pacienteService.Deletar(paciente);
            TempData["Sucesso"] = "Registro Deletado com Sucesso!";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReportForEstadoPaciente(Guid id)
        {
            if (id == null) return NotFound();

            var pacientePorEstado = await _pacienteService.ObterPacientesPorEstadoPaciente(id);
            var pacienteViewModel = _mapper.Map<IEnumerable<PacienteViewModel>>(pacientePorEstado);

            if (pacienteViewModel == null) return NotFound();

            return View(pacienteViewModel);
        }





    }
}
