using AutoMapper;
using Cooperchip.ItDeveloper.Domain.Entities;
using CooperchipItDeveloper.Mvc.ViewModels;

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
