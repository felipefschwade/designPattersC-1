using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.DesignPatterns.Vendas;

namespace Empresa.DesignPatterns.Impostos
{
    public class ICC : Imposto
    {
        public ICC(Imposto outroImposto) : base(outroImposto) { }
        public ICC() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            double valorICC;
            if (orcamento.Valor < 1000)
            {
                valorICC = orcamento.Valor * 0.05;
            }
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
            {
                valorICC = orcamento.Valor * 0.07;
            }
            else
            {
                 valorICC = orcamento.Valor * 0.08 + 30;
            }
            return valorICC + CalculaOutroImposto(orcamento);
        }
    }
}
