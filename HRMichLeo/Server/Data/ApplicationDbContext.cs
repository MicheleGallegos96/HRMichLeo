using HRMichLeo.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace HRMichLeo.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Sede> Sedi { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sede>()
            .HasKey(s => s.Id);
        }
    }
}
