using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class Mansione 
    {
        public Guid Id { get; set; }
        public string DescrizioneMansione { get; set; } = null!;
        public bool AttivoMansione {  get; set; }

        public virtual ICollection<EsperienzaLavorativa> EsperienzeLavorative { get; set; } = new List<EsperienzaLavorativa>();
    }
}
