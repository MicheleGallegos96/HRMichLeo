using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class SoftSkill 
    {
        public Guid Id { get; set; }
        public string DescrizioneSoftSkills { get; set; } = null!;
        public bool AttivoSS {  get; set; }
    }
}
