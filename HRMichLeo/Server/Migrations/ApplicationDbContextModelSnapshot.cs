﻿// <auto-generated />
using System;
using HRMichLeo.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRMichLeo.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BenefitTipologiaContratto", b =>
                {
                    b.Property<Guid>("BenefitsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TipologiaContrattiId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BenefitsId", "TipologiaContrattiId");

                    b.HasIndex("TipologiaContrattiId");

                    b.ToTable("BenefitTipologiaContratto");
                });

            modelBuilder.Entity("DatiColloquianteHardSkill", b =>
                {
                    b.Property<Guid>("ColloquiantiId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HardSkillsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ColloquiantiId", "HardSkillsId");

                    b.HasIndex("HardSkillsId");

                    b.ToTable("DatiColloquianteHardSkill");
                });

            modelBuilder.Entity("DatiColloquianteSoftSkill", b =>
                {
                    b.Property<Guid>("ColloquiantiId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SoftSkillsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ColloquiantiId", "SoftSkillsId");

                    b.HasIndex("SoftSkillsId");

                    b.ToTable("DatiColloquianteSoftSkill");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.Benefit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AttivoBenefit")
                        .HasColumnType("bit");

                    b.Property<string>("DescrizioneBenefit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Benefits");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.DatiColloquiante", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CittaDiResidenza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComuneDiNascita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ContrattoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DocumentoId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvinciaDiNascita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvinciaDiResidenza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecapitoTel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatoDiNascita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatoDiResidenza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TitoloStudioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ContrattoId");

                    b.HasIndex("TitoloStudioId");

                    b.ToTable("DatiColloquianti");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.EsperienzaLavorativa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Azienda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ContrattoRichiestoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DataFine")
                        .HasColumnType("int");

                    b.Property<int>("DataInizio")
                        .HasColumnType("int");

                    b.Property<string>("DescrizioneAttivitaSvolte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MansioneId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ContrattoRichiestoId");

                    b.HasIndex("MansioneId");

                    b.ToTable("EsperienzeLavorative");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.HardSkill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AttivoHS")
                        .HasColumnType("bit");

                    b.Property<string>("DescrizioneHardSkills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HardSkills");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.LivelloContrattuale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AttivoLvlContrattuali")
                        .HasColumnType("bit");

                    b.Property<string>("DescrizioneLivelliContrattuali")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LivelliContrattuali");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.Mansione", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AttivoMansione")
                        .HasColumnType("bit");

                    b.Property<string>("DescrizioneMansione")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mansioni");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.Referente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecapitoTel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SedeReferenteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SedeReferenteId");

                    b.ToTable("Referenti");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.Sede", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Citta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescrizioneSede")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Indirizzo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NCivico")
                        .HasColumnType("int");

                    b.Property<string>("Provincia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecapitoTel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Scala")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sedi");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.SoftSkill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AttivoSS")
                        .HasColumnType("bit");

                    b.Property<string>("DescrizioneSoftSkills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SoftSkills");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.TipologiaColloquio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AttivoTipoColloquio")
                        .HasColumnType("bit");

                    b.Property<Guid?>("CandidatoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DataColloquio")
                        .HasColumnType("int");

                    b.Property<string>("DescrizioneTipoColloquio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ReferenteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SedeColloquioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Valutazione")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.HasIndex("ReferenteId");

                    b.HasIndex("SedeColloquioId");

                    b.ToTable("TipologieColloquio");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.TipologiaContratto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AttivoTipoContratto")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ColloquianteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescrizioneTipoContratto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("LivelloContrattoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ColloquianteId");

                    b.HasIndex("LivelloContrattoId");

                    b.ToTable("TipologieContratti");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.TipologiaDocumento", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AttivoTipoDoc")
                        .HasColumnType("bit");

                    b.Property<string>("DescrizioneTipoDoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipologieDocumenti");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.TitoloDiStudio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AttivoTitoli")
                        .HasColumnType("bit");

                    b.Property<string>("DescrizioneTitoliDiStudio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TitoliDiStudio");
                });

            modelBuilder.Entity("BenefitTipologiaContratto", b =>
                {
                    b.HasOne("HRMichLeo.Shared.Models.Benefit", null)
                        .WithMany()
                        .HasForeignKey("BenefitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRMichLeo.Shared.Models.TipologiaContratto", null)
                        .WithMany()
                        .HasForeignKey("TipologiaContrattiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DatiColloquianteHardSkill", b =>
                {
                    b.HasOne("HRMichLeo.Shared.Models.DatiColloquiante", null)
                        .WithMany()
                        .HasForeignKey("ColloquiantiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRMichLeo.Shared.Models.HardSkill", null)
                        .WithMany()
                        .HasForeignKey("HardSkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DatiColloquianteSoftSkill", b =>
                {
                    b.HasOne("HRMichLeo.Shared.Models.DatiColloquiante", null)
                        .WithMany()
                        .HasForeignKey("ColloquiantiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRMichLeo.Shared.Models.SoftSkill", null)
                        .WithMany()
                        .HasForeignKey("SoftSkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.DatiColloquiante", b =>
                {
                    b.HasOne("HRMichLeo.Shared.Models.TipologiaContratto", "Contratto")
                        .WithMany()
                        .HasForeignKey("ContrattoId");

                    b.HasOne("HRMichLeo.Shared.Models.TitoloDiStudio", "TitoloStudio")
                        .WithMany("Colloquianti")
                        .HasForeignKey("TitoloStudioId");

                    b.Navigation("Contratto");

                    b.Navigation("TitoloStudio");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.EsperienzaLavorativa", b =>
                {
                    b.HasOne("HRMichLeo.Shared.Models.TipologiaContratto", "ContrattoRichiesto")
                        .WithMany("EsperienzeLavorative")
                        .HasForeignKey("ContrattoRichiestoId");

                    b.HasOne("HRMichLeo.Shared.Models.Mansione", "Mansione")
                        .WithMany("EsperienzeLavorative")
                        .HasForeignKey("MansioneId");

                    b.Navigation("ContrattoRichiesto");

                    b.Navigation("Mansione");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.Referente", b =>
                {
                    b.HasOne("HRMichLeo.Shared.Models.Sede", "SedeReferente")
                        .WithMany("Referenti")
                        .HasForeignKey("SedeReferenteId");

                    b.Navigation("SedeReferente");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.TipologiaColloquio", b =>
                {
                    b.HasOne("HRMichLeo.Shared.Models.DatiColloquiante", "Candidato")
                        .WithMany("Colloqui")
                        .HasForeignKey("CandidatoId");

                    b.HasOne("HRMichLeo.Shared.Models.Referente", "Referente")
                        .WithMany("Colloqui")
                        .HasForeignKey("ReferenteId");

                    b.HasOne("HRMichLeo.Shared.Models.Sede", "SedeColloquio")
                        .WithMany()
                        .HasForeignKey("SedeColloquioId");

                    b.Navigation("Candidato");

                    b.Navigation("Referente");

                    b.Navigation("SedeColloquio");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.TipologiaContratto", b =>
                {
                    b.HasOne("HRMichLeo.Shared.Models.DatiColloquiante", "Colloquiante")
                        .WithMany("Contratti")
                        .HasForeignKey("ColloquianteId");

                    b.HasOne("HRMichLeo.Shared.Models.LivelloContrattuale", "LivelloContratto")
                        .WithMany("TipologiaContratti")
                        .HasForeignKey("LivelloContrattoId");

                    b.Navigation("Colloquiante");

                    b.Navigation("LivelloContratto");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.TipologiaDocumento", b =>
                {
                    b.HasOne("HRMichLeo.Shared.Models.DatiColloquiante", "Colloquiante")
                        .WithOne("Documento")
                        .HasForeignKey("HRMichLeo.Shared.Models.TipologiaDocumento", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colloquiante");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.DatiColloquiante", b =>
                {
                    b.Navigation("Colloqui");

                    b.Navigation("Contratti");

                    b.Navigation("Documento");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.LivelloContrattuale", b =>
                {
                    b.Navigation("TipologiaContratti");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.Mansione", b =>
                {
                    b.Navigation("EsperienzeLavorative");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.Referente", b =>
                {
                    b.Navigation("Colloqui");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.Sede", b =>
                {
                    b.Navigation("Referenti");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.TipologiaContratto", b =>
                {
                    b.Navigation("EsperienzeLavorative");
                });

            modelBuilder.Entity("HRMichLeo.Shared.Models.TitoloDiStudio", b =>
                {
                    b.Navigation("Colloquianti");
                });
#pragma warning restore 612, 618
        }
    }
}
