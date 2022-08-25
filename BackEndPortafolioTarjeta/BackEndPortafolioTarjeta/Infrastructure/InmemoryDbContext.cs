using Microsoft.EntityFrameworkCore;
using TarjetaCredito.Domain.DomainObject;

namespace BackEndPortafolioTarjeta.Infrastructure
{
    public class InmemoryDbContext : DbContext
    {
        public DbSet<SolicitudHogwarts> solicitudHogwarts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryDatabase("MyDb");
        }
    }
}
