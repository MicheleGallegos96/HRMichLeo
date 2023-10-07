using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class Mansioni 
    {
        public Guid Id { get; set; }
        public string DescrizioneMansione { get; set; } = "";
        public bool AttivoMansione {  get; set; }
    }
}
