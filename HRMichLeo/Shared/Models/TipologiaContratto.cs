using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class TipologiaContratto
    {
        public Guid Id { get; set; }
        public string DescrizioneTipoContratto { get; set; } = null!;
        public LivelloContrattuale? LivelloContratto { get; set; }
        public DatiColloquiante? Colloquiante { get; set; }
        public bool AttivoTipoContratto { get; set; }


        public virtual ICollection<EsperienzaLavorativa> EsperienzeLavorative { get; set; } = new List<EsperienzaLavorativa>();
        public virtual ICollection<Benefit> Benefits { get; set; } = new List<Benefit>();
        
    }
}
