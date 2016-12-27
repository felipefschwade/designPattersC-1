using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.DesignPatterns.Vendas;

namespace Empresa.DesignPatterns.Impostos
{
    public class IHIT : TemplateImposto
    {
        public IHIT(Imposto outroImposto) : base(outroImposto) { }
        public IHIT() : base() { }
        protected override bool DeveUsarTaxaMaxima(Orcamento orcamento)
        {
            IList<string> noOrcamento = new List<string>();
            foreach (var item in orcamento.Itens)
            {
                if (noOrcamento.Contains(item.Nome))
                {
                    return true;
                }
                noOrcamento.Add(item.Nome);
            }
            return false;
        }

        protected override double TaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        protected override double TaxacaoMinima(Orcamento orcamento)
        {
            return (orcamento.Itens.Count * 0.01) * orcamento.Valor;
        }
    }
}
