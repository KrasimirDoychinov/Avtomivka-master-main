namespace Avtomivka.A.Data
{
    using Avtomivka.A.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System.Diagnostics.CodeAnalysis;

    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext([NotNull] DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Program> Programs { get; set; }

        public DbSet<WashReservation> WashReservations { get; set; }

        public DbSet<Worker> Workers { get; set; }

        public DbSet<Colon> Colons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Avtomivka;Integrated Security=true;");
            }

            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
