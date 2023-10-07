using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class TitoliDiStudi 
    {
        public Guid Id { get; set; }
        public string DescrizioneTitoliDiStudio { get; set; } = "";
        public bool AttivoTitoli {  get; set; }
    }
}
