using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class Referente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Cognome { get; set; } = null!;
        public string CF { get; set; } = null!;
        public string? RecapitoTel { get; set; } 
        public string? Email { get; set; } 
        //public Guid? SedeId { get; set; }
        public Sede? SedeReferente { get; set; }
        public virtual ICollection<TipologiaColloquio> Colloqui { get; set; } = new List <TipologiaColloquio>();
    }
}
