using Empresa.DesignPatterns.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DesignPatterns.Impostos
{
    public abstract class Imposto
    {

        Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }
        public Imposto() { }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculaOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }
      
    }
}
