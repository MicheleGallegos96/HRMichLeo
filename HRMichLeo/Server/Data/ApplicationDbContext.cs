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
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TipologiaContratto>(entity =>
            {
                entity.HasOne(a => a.Colloquiante)
                    .WithMany(a => a.Contratti)
                    .OnDelete(DeleteBehavior.NoAction);
                    

            });
            //modelBuilder.Entity<DatiColloquiante>(entity =>
            //{
            //    entity.HasOne(a => a.Documento)
            //        .WithOne(a => a.Colloquiante)
            //        .HasForeignKey<TipologiaDocumento>(a => a.Id);

            //});

            //modelBuilder.Entity<TipologiaDocumento>(entity =>
            //{
            //    entity.HasOne(a => a.Colloquiante)
            //        .WithOne(a => a.Documento)
            //        .HasForeignKey<TipologiaDocumento>(a => a.Id);
            //});

            modelBuilder.Entity<Sede>()
                .HasMany(r => r.Referenti)
                .WithOne(s => s.SedeReferente)
                .HasForeignKey(f => f.Id);
        }
    }
}
