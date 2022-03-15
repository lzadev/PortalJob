using AutoMapper;
using PortalJob.BusinessLogic.Dtos;
using PortalJob.Domain.Entities;

namespace PortalJob.BusinessLogic.Mappings
{
    public class VacancyProfile : Profile
    {
        public VacancyProfile()
        {
            CreateMap<Vacancy, VacancyDto>();
        }
    }
}
