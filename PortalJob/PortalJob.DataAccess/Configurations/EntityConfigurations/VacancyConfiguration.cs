namespace PortalJob.DataAccess.Configurations.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PortalJob.Domain.Entities;

    internal class VacancyConfiguration : IEntityTypeConfiguration<Vacancy>
    {
        public void Configure(EntityTypeBuilder<Vacancy> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.BusinessName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.ContactName)
                .HasMaxLength(100);

            builder.Property(x => x.EmailContact)
                .HasMaxLength(50);

            builder.Property(x => x.PhoneNumber)
                .HasMaxLength(25);

            builder.Property(x => x.Title)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Description)
                .IsRequired();

            builder.Property(x => x.Provice)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.EmailContact)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.PublishedAt)
                .HasDefaultValue(DateTime.Now);

            builder.Property(x => x.DeletedAt)
                .HasDefaultValue(null);

            builder.Property(x => x.IsDeleted)
                .HasDefaultValue(false);
        }
    }
}
