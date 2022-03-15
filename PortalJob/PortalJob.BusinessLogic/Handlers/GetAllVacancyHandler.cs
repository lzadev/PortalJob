namespace PortalJob.BusinessLogic.Handlers
{
    using AutoMapper;
    using MediatR;
    using PortalJob.BusinessLogic.Dtos;
    using PortalJob.BusinessLogic.Exceptions;
    using PortalJob.BusinessLogic.Queries;
    using PortalJob.DataAccess.Repositories.Abstract;

    public class GetAllVacancyHandler : IRequestHandler<GetAllVacancyQuery, Response<IEnumerable<VacancyDto>>>
    {
        private readonly IVacancyRepository _vacancyRepository;
        private readonly IMapper _mapper;

        public GetAllVacancyHandler(IVacancyRepository vacancyRepository, IMapper mapper)
        {
            _vacancyRepository = vacancyRepository;
            _mapper = mapper;
        }
        public async Task<Response<IEnumerable<VacancyDto>>> Handle(GetAllVacancyQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _vacancyRepository.GetAll(x => !x.IsDeleted);
                var vacancies = _mapper.Map<IEnumerable<VacancyDto>>(result);
                return Response<IEnumerable<VacancyDto>>.Ok(vacancies, vacancies.Count());
            }
            catch (Exception ex)
            {
                throw new InternalErrorException(ex.Message);
            }
        }
    }
}
