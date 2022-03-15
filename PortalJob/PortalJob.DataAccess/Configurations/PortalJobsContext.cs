namespace PortalJob.DataAccess.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using PortalJob.DataAccess.Configurations.EntityConfigurations;
    using PortalJob.Domain.Entities;
    public class PortalJobsContext : DbContext
    {
        public DbSet<Vacancy> Vacancies { get; set; }
        public PortalJobsContext(DbContextOptions<PortalJobsContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VacancyConfiguration());
        }
    }
}
