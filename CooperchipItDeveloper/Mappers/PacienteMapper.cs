using AutoMapper;
using Cooperchip.ItDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Application.Areas.Pacientes.Models;
using Cooperchip.ITDeveloper.Application.ViewModels;

namespace Cooperchip.ItDeveloper.Mvc.Mappers
{
    public class PacienteMapper : Profile
    {
        public PacienteMapper() 
        {
            CreateMap<Paciente, PacienteViewModel>().ReverseMap();

            CreateMap<Paciente, PacienteGridModel>().ReverseMap();

            CreateMap<Paciente, PacienteFormModel>().ReverseMap();
        }
    }
}
