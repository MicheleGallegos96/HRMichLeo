﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMichLeo.Shared.Models
{
    public class LivelloContrattuale 
    {
        public Guid Id { get; set; }
        public string DescrizioneLivelliContrattuali { get; set; } = null!;
        public bool AttivoLvlContrattuali {  get; set; }

        public virtual ICollection<TipologiaContratto> TipologiaContratti { get; set; } = new List<TipologiaContratto>();
    }
}
