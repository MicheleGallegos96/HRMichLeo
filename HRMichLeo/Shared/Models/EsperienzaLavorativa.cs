using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class EsperienzaLavorativa
    {
        public Guid Id { get; set; }
        public DateFormat DataInizio { get; set; }
        public DateFormat DataFine { get; set; }
        public Mansione Mansione { get; set; }
        public string? Azienda { get; set; }  
        public string? DescrizioneAttivitaSvolte { get; set; } 
        public TipologiaContratto ContrattoRichiesto { get; set; }
    }
}
