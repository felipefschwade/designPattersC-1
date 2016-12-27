using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.DesignPatterns.Vendas;

namespace Empresa.DesignPatterns.Impostos
{
    public abstract class TemplateImposto : Imposto
    {
        public TemplateImposto(Imposto outroImposto) : base(outroImposto) { }
        public TemplateImposto() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarTaxaMaxima(orcamento))
            {
                return TaxacaoMaxima(orcamento) + CalculaOutroImposto(orcamento);
            }
            return TaxacaoMinima(orcamento) + CalculaOutroImposto(orcamento);
        }

        protected abstract bool DeveUsarTaxaMaxima(Orcamento orcamento);
        protected abstract double TaxacaoMaxima(Orcamento orcamento);
        protected abstract double TaxacaoMinima(Orcamento orcamento);
    }
}
