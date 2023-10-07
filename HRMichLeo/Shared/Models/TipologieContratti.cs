using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class TipologieContratti 
    {
        public Guid Id { get; set; }
        public string DescrizioneTipoContratto { get; set; } = "";
        public bool AttivoTipoContratto {  get; set; }
    }
}
