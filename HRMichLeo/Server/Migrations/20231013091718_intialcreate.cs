using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMichLeo.Server.Migrations
{
    /// <inheritdoc />
    public partial class intialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Benefits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescrizioneBenefit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttivoBenefit = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescrizioneHardSkills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttivoHS = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LivelliContrattuali",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescrizioneLivelliContrattuali = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttivoLvlContrattuali = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivelliContrattuali", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mansioni",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescrizioneMansione = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttivoMansione = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mansioni", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sedi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescrizioneSede = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indirizzo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NCivico = table.Column<int>(type: "int", nullable: false),
                    Scala = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Citta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecapitoTel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoftSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescrizioneSoftSkills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttivoSS = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TitoliDiStudio",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescrizioneTitoliDiStudio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttivoTitoli = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitoliDiStudio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Referenti",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecapitoTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SedeReferenteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referenti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Referenti_Sedi_SedeReferenteId",
                        column: x => x.SedeReferenteId,
                        principalTable: "Sedi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BenefitTipologiaContratto",
                columns: table => new
                {
                    BenefitsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipologiaContrattiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenefitTipologiaContratto", x => new { x.BenefitsId, x.TipologiaContrattiId });
                    table.ForeignKey(
                        name: "FK_BenefitTipologiaContratto_Benefits_BenefitsId",
                        column: x => x.BenefitsId,
                        principalTable: "Benefits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatiColloquianteHardSkill",
                columns: table => new
                {
                    ColloquiantiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HardSkillsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatiColloquianteHardSkill", x => new { x.ColloquiantiId, x.HardSkillsId });
                    table.ForeignKey(
                        name: "FK_DatiColloquianteHardSkill_HardSkills_HardSkillsId",
                        column: x => x.HardSkillsId,
                        principalTable: "HardSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatiColloquianteSoftSkill",
                columns: table => new
                {
                    ColloquiantiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoftSkillsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatiColloquianteSoftSkill", x => new { x.ColloquiantiId, x.SoftSkillsId });
                    table.ForeignKey(
                        name: "FK_DatiColloquianteSoftSkill_SoftSkills_SoftSkillsId",
                        column: x => x.SoftSkillsId,
                        principalTable: "SoftSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatiColloquianti",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComuneDiNascita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinciaDiNascita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatoDiNascita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CittaDiResidenza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinciaDiResidenza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatoDiResidenza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecapitoTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContrattoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TitoloStudioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DocumentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatiColloquianti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatiColloquianti_TitoliDiStudio_TitoloStudioId",
                        column: x => x.TitoloStudioId,
                        principalTable: "TitoliDiStudio",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TipologieColloquio",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescrizioneTipoColloquio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttivoTipoColloquio = table.Column<bool>(type: "bit", nullable: false),
                    DataColloquio = table.Column<int>(type: "int", nullable: false),
                    ReferenteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SedeColloquioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CandidatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Valutazione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipologieColloquio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipologieColloquio_DatiColloquianti_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "DatiColloquianti",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TipologieColloquio_Referenti_ReferenteId",
                        column: x => x.ReferenteId,
                        principalTable: "Referenti",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TipologieColloquio_Sedi_SedeColloquioId",
                        column: x => x.SedeColloquioId,
                        principalTable: "Sedi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TipologieContratti",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescrizioneTipoContratto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LivelloContrattoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ColloquianteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AttivoTipoContratto = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipologieContratti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipologieContratti_DatiColloquianti_ColloquianteId",
                        column: x => x.ColloquianteId,
                        principalTable: "DatiColloquianti",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TipologieContratti_LivelliContrattuali_LivelloContrattoId",
                        column: x => x.LivelloContrattoId,
                        principalTable: "LivelliContrattuali",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TipologieDocumenti",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescrizioneTipoDoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttivoTipoDoc = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipologieDocumenti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipologieDocumenti_DatiColloquianti_Id",
                        column: x => x.Id,
                        principalTable: "DatiColloquianti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EsperienzeLavorative",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataInizio = table.Column<int>(type: "int", nullable: false),
                    DataFine = table.Column<int>(type: "int", nullable: false),
                    MansioneId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Azienda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescrizioneAttivitaSvolte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContrattoRichiestoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EsperienzeLavorative", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EsperienzeLavorative_Mansioni_MansioneId",
                        column: x => x.MansioneId,
                        principalTable: "Mansioni",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EsperienzeLavorative_TipologieContratti_ContrattoRichiestoId",
                        column: x => x.ContrattoRichiestoId,
                        principalTable: "TipologieContratti",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BenefitTipologiaContratto_TipologiaContrattiId",
                table: "BenefitTipologiaContratto",
                column: "TipologiaContrattiId");

            migrationBuilder.CreateIndex(
                name: "IX_DatiColloquianteHardSkill_HardSkillsId",
                table: "DatiColloquianteHardSkill",
                column: "HardSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_DatiColloquianteSoftSkill_SoftSkillsId",
                table: "DatiColloquianteSoftSkill",
                column: "SoftSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_DatiColloquianti_ContrattoId",
                table: "DatiColloquianti",
                column: "ContrattoId");

            migrationBuilder.CreateIndex(
                name: "IX_DatiColloquianti_TitoloStudioId",
                table: "DatiColloquianti",
                column: "TitoloStudioId");

            migrationBuilder.CreateIndex(
                name: "IX_EsperienzeLavorative_ContrattoRichiestoId",
                table: "EsperienzeLavorative",
                column: "ContrattoRichiestoId");

            migrationBuilder.CreateIndex(
                name: "IX_EsperienzeLavorative_MansioneId",
                table: "EsperienzeLavorative",
                column: "MansioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Referenti_SedeReferenteId",
                table: "Referenti",
                column: "SedeReferenteId");

            migrationBuilder.CreateIndex(
                name: "IX_TipologieColloquio_CandidatoId",
                table: "TipologieColloquio",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_TipologieColloquio_ReferenteId",
                table: "TipologieColloquio",
                column: "ReferenteId");

            migrationBuilder.CreateIndex(
                name: "IX_TipologieColloquio_SedeColloquioId",
                table: "TipologieColloquio",
                column: "SedeColloquioId");

            migrationBuilder.CreateIndex(
                name: "IX_TipologieContratti_ColloquianteId",
                table: "TipologieContratti",
                column: "ColloquianteId");

            migrationBuilder.CreateIndex(
                name: "IX_TipologieContratti_LivelloContrattoId",
                table: "TipologieContratti",
                column: "LivelloContrattoId");

            migrationBuilder.AddForeignKey(
                name: "FK_BenefitTipologiaContratto_TipologieContratti_TipologiaContrattiId",
                table: "BenefitTipologiaContratto",
                column: "TipologiaContrattiId",
                principalTable: "TipologieContratti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DatiColloquianteHardSkill_DatiColloquianti_ColloquiantiId",
                table: "DatiColloquianteHardSkill",
                column: "ColloquiantiId",
                principalTable: "DatiColloquianti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DatiColloquianteSoftSkill_DatiColloquianti_ColloquiantiId",
                table: "DatiColloquianteSoftSkill",
                column: "ColloquiantiId",
                principalTable: "DatiColloquianti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DatiColloquianti_TipologieContratti_ContrattoId",
                table: "DatiColloquianti",
                column: "ContrattoId",
                principalTable: "TipologieContratti",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatiColloquianti_TipologieContratti_ContrattoId",
                table: "DatiColloquianti");

            migrationBuilder.DropTable(
                name: "BenefitTipologiaContratto");

            migrationBuilder.DropTable(
                name: "DatiColloquianteHardSkill");

            migrationBuilder.DropTable(
                name: "DatiColloquianteSoftSkill");

            migrationBuilder.DropTable(
                name: "EsperienzeLavorative");

            migrationBuilder.DropTable(
                name: "TipologieColloquio");

            migrationBuilder.DropTable(
                name: "TipologieDocumenti");

            migrationBuilder.DropTable(
                name: "Benefits");

            migrationBuilder.DropTable(
                name: "HardSkills");

            migrationBuilder.DropTable(
                name: "SoftSkills");

            migrationBuilder.DropTable(
                name: "Mansioni");

            migrationBuilder.DropTable(
                name: "Referenti");

            migrationBuilder.DropTable(
                name: "Sedi");

            migrationBuilder.DropTable(
                name: "TipologieContratti");

            migrationBuilder.DropTable(
                name: "DatiColloquianti");

            migrationBuilder.DropTable(
                name: "LivelliContrattuali");

            migrationBuilder.DropTable(
                name: "TitoliDiStudio");
        }
    }
}
