﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DesignPatterns.Vendas.Descontos
{
    public class DescontoParaMaisDe10Itens : Desconto
    {
        public Desconto proximo {get; set;}

        public double calcula(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 10)
            {
                return orcamento.Valor * 0.10;
            }
            return proximo.calcula(orcamento);
        }
    }
}
