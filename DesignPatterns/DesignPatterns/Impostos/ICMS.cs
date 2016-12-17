﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.DesignPatterns.Vendas;

namespace Empresa.DesignPatterns.Impostos
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return 50.0 + orcamento.Valor * 0.05;
        }
    }
}
