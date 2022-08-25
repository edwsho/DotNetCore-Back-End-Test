using BackEndPortafolioTarjeta.Infrastructure.Configs;
using TarjetaCredito.Domain.DomainObject;
using Microsoft.EntityFrameworkCore;

namespace BackEndPortafolioTarjeta.Infrastructure
{
    public class SolicitudHogwartsDbContext : DbContext
    {
        public DbSet<SolicitudHogwarts> solicitudHogwarts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(local)\\sqlexpress;Database=SolicitudHogwartsDb;Trusted_Connection=True;MultipleActiveResultSets=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new SolicitudHogwartsConfig());

        }

    }
}
