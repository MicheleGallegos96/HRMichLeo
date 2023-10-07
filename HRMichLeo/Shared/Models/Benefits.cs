using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class Benefits 
    {
        public Guid Id { get; set; }
        public string DescrizioneBenefit { get; set; } = "";
        public bool AttivoBenefit {  get; set; }
    }
}
