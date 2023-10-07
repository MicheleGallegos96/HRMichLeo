using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class LivelloContrattuale 
    {
        public Guid Id { get; set; }
        public string DescrizioneLivelliContrattuali { get; set; } = "";
        public bool AttivoLvlContrattuali {  get; set; }
    }
}
