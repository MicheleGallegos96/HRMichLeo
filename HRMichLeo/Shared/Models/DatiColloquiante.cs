using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class DatiColloquiante
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Cognome { get; set; } = null!;
        public string? ComuneDiNascita { get; set; } 
        public string? ProvinciaDiNascita { get; set; } 
        public string? StatoDiNascita { get; set; }
        public string? CittaDiResidenza { get; set; } 
        public string? ProvinciaDiResidenza { get; set; } 
        public string? StatoDiResidenza { get; set; } 
        public string? RecapitoTel { get; set; }  
        public string? Email { get; set; } 
        public TipologiaContratto? Contratto { get; set; }
        public TipologiaDocumento? Documento { get; set; }
        public TitoloDiStudio? TitoloStudio { get; set; }

        public virtual ICollection<HardSkill> HardSkills { get; set; } = new List<HardSkill>();
        public virtual ICollection<SoftSkill> SoftSkills { get; set; } = new List<SoftSkill>();
        public virtual ICollection<TipologiaColloquio> Colloqui { get; set; } = new List<TipologiaColloquio>();

    }
}
