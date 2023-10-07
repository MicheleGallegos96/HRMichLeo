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
        public string Nome { get; set; } = "";
        public string Cognome { get; set; } = "";
        public string ComuneDiNascita { get; set; } = "";
        public string ProvinciaDiNascita { get; set; } = "";
        public string StatoDiNascita { get; set; } = "";
        public string CittaDiResidenza { get; set; } = "";
        public string ProvinciaDiResidenza { get; set; } = "";
        public string StatoDiResidenza { get; set; } = "";
        public string RecapitoTel { get; set; } = "";
        public string Email { get; set; } = "";

    }
}
