using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class SoftSkills 
    {
        public Guid Id { get; set; }
        public string DescrizioneSoftSkills { get; set; } = "";
        public bool AttivoSS {  get; set; }
    }
}
