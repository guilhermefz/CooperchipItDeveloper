using AutoMapper;
using Cooperchip.ItDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Application.ViewModels;

namespace Cooperchip.ItDeveloper.Mvc.Mappers
{
    public class PacienteMapper : Profile
    {
        public PacienteMapper() 
        {
            CreateMap<Paciente, PacienteViewModel>().ReverseMap();
        }
    }
}
