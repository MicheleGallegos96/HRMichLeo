using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class TipologieDocumenti 
    {
        public Guid Id { get; set; }
        public string DescrizioneTipoDoc { get; set; } = "";
        public bool AttivoTipoTipoDoc {  get; set; }
    }
}
