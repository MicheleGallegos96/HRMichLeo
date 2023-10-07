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
        public string Nome { get; set; } = "";
        public string Cognome { get; set; } = "";
        public string CF { get; set; } = "";
        public string RecapitoTel { get; set; } = "";
        public string Email { get; set; } = "";
    }
}
