using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class TipologiaContratto 
    {
        public Guid Id { get; set; }
        public string DescrizioneTipoContratto { get; set; } = null!;
        public bool AttivoTipoContratto {  get; set; }
    }
}
