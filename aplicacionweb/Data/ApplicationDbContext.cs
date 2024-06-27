using aplicacionweb.Models;
using Microsoft.EntityFrameworkCore;
namespace aplicacionweb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Oferta> Ofertas { get; set; }
        public DbSet<TipoOferta> TipoOferta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TipoOferta>()
                .HasMany(tp => tp.Oferta)
                .WithOne(p => p.TipoOferta);
        }

    }
}
