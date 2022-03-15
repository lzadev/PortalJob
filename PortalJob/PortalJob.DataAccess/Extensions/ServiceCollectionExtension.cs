namespace PortalJob.DataAccess.Extensions
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using PortalJob.DataAccess.Configurations;
    using PortalJob.DataAccess.Repositories.Abstract;
    using PortalJob.DataAccess.Repositories.Concret;

    public static class ServiceCollectionExtension
    {
        public static void DataAccessServicesRegister(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PortalJobsContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("jobs")));

            services.AddScoped(typeof(IGerericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IVacancyRepository, VacancyRepository>();
        }
    }
}
