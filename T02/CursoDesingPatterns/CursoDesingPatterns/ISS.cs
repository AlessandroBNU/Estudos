﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
   public class ISS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.valor * 0.6;
        }
    }
}
