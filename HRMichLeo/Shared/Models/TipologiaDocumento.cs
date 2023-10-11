﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class TipologiaDocumento 
    {
        public Guid Id { get; set; }
        public string DescrizioneTipoDoc { get; set; } = null!;
        public bool AttivoTipoDoc {  get; set; }
        public DatiColloquiante? Colloquiante { get; set; }
    }
}
