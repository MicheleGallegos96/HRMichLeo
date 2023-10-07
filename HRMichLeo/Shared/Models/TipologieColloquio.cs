﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class TipologieColloquio
    {
        public Guid Id { get; set; }
        public string DescrizioneTipoColloquio { get; set; } = "";
        public bool AttivoTipoColloquio {  get; set; }
        public DateOnly DataColloquio { get; set; }
        public Referente Referente { get; set; }
        public Sedi SedeColloquio { get; set; }
        public DatiColloquiante Candidato { get; set; }
        public string Valutazione { get; set; } = "";
        public string Note { get; set; } = "";
    }
}
