using HRMichLeo.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace HRMichLeo.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Benefit> Benefits { get; set; }
        public DbSet<DatiColloquiante> DatiColloquianti { get; set; }
        public DbSet<EsperienzaLavorativa> EsperienzeLavorative { get; set; }
        public DbSet<HardSkill> HardSkills { get; set; }
        public DbSet<LivelloContrattuale> LivelliContrattuali { get; set; }
        public DbSet<Mansione> Mansioni { get; set; }
        public DbSet<Referente> Referenti { get; set; }
        public DbSet<Sede> Sedi { get; set; }
        public DbSet<SoftSkill> SoftSkills { get; set; }
        public DbSet<TipologiaColloquio> TipologieColloquio { get; set; }
        public DbSet<TipologiaContratto> TipologieContratti { get; set; }
        public DbSet<TipologiaDocumento> TipologieDocumenti { get; set; }
        public DbSet<TitoloDiStudio> TitoliDiStudio { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sede>()
            .HasKey(s => s.Id);
        }
    }
}
