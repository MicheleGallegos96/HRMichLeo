using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class TitoloDiStudio
    {
        public Guid Id { get; set; }
        public string DescrizioneTitoliDiStudio { get; set; } = null!;
        public bool AttivoTitoli {  get; set; }
        public virtual ICollection<DatiColloquiante> Colloquianti { get; set; } = new List <DatiColloquiante>();
    }
}
