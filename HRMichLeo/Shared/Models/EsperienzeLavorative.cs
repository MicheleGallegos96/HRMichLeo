using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class EsperienzeLavorative
    {
        public Guid Id { get; set; }
        public DateOnly DataInizio { get; set; }
        public DateOnly DataFine { get; set; }
        public Mansioni Mansione { get; set; }
        public string Azienda { get; set; } = "";
        public string DescrizioneAttivitaSvolte { get; set; } = "";
        public TipologieContratti ContrattoRichiesto { get; set; }
    }
}
