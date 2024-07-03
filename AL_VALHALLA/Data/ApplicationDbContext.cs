using Microsoft.EntityFrameworkCore;
using AL_VALHALLA.Models;

namespace AL_VALHALLA.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<ReservaModel> Reservas { get; set; }
        public DbSet<DestinoModel> Destinos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
