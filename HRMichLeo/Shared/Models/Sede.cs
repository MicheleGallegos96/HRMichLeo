using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class Sede
    {
        public Guid Id { get; set; }
        public string DescrizioneSede { get; set; } = null!; 
        public string? Indirizzo { get; set; } 
        public int NCivico { get; set; }
        public string? Scala { get; set; } 
        public string? Cap { get; set; } 
        public string? Provincia { get; set; } 
        public string? Citta { get; set; } 
        public string? RecapitoTel { get; set; } 
       
        public ICollection<Referente?> Referenti { get; set;} = new List<Referente>();
    }
}
