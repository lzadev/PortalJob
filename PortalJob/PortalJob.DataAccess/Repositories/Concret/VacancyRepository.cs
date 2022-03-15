namespace PortalJob.DataAccess.Repositories.Concret
{
    using PortalJob.DataAccess.Configurations;
    using PortalJob.DataAccess.Repositories.Abstract;
    using PortalJob.Domain.Entities;

    public class VacancyRepository : GenericRepository<Vacancy>, IVacancyRepository
    {
        public VacancyRepository(PortalJobsContext context) : base(context)
        {
        }
    }
}
