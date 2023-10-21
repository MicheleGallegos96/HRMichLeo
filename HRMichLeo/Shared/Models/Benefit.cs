using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class Benefit 
    {
        public Guid Id { get; set; }
        public string DescrizioneBenefit { get; set; } = null!;
        public bool AttivoBenefit {  get; set; }

        public virtual ICollection<TipologiaContratto> TipologiaContratti { get; set; } = new List<TipologiaContratto>();

      
    }
}
