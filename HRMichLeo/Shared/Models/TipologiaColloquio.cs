using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class TipologiaColloquio
    {
        public Guid Id { get; set; }
        public string DescrizioneTipoColloquio { get; set; } = "";
        public bool AttivoTipoColloquio {  get; set; }
        public DateFormat DataColloquio { get; set; }
        public Referente Referente { get; set; }
        public Sede SedeColloquio { get; set; }
        public DatiColloquiante Candidato { get; set; }
        public string Valutazione { get; set; } = "";
        public string Note { get; set; } = "";
    }
}
