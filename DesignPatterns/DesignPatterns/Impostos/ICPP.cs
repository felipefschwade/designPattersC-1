﻿using Empresa.DesignPatterns.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DesignPatterns.Impostos
{
    public class ICPP : TemplateImposto
    {   
        protected override bool DeveUsarTaxaMaxima(Orcamento orcamento)
        {
            return orcamento.Valor > 500;
        }

        protected override double TaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override double TaxacaoMinima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
