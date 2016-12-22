using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.DesignPatterns.Vendas;

namespace Empresa.DesignPatterns.Impostos
{
    public class IKCV : TemplateImposto
    {
        protected override bool DeveUsarTaxaMaxima(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                foreach (var item in orcamento.Itens)
                {
                    return item.Preco > 100;
                }
            }
            return false;
        }

        protected override double TaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double TaxacaoMinima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
