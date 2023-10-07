using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class HardSkills
    {
        public Guid Id { get; set; }
        public string DescrizioneHardSkills { get; set; } = "";
        public bool AttivoHS { get; set; }
    }
}
