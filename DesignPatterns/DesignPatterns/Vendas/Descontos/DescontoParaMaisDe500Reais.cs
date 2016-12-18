using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DesignPatterns.Vendas.Descontos
{
    class DescontoParaMaisDe500Reais : Desconto
    {
        public Desconto proximo { get; set;}

        public double calcula(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }
            return proximo.calcula(orcamento);
        }
    }
}
