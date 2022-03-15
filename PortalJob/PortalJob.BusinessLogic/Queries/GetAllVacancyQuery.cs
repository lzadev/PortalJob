namespace PortalJob.BusinessLogic.Queries
{
    using MediatR;
    using PortalJob.BusinessLogic.Dtos;
    public record GetAllVacancyQuery() : IRequest<Response<IEnumerable<VacancyDto>>>;
}
