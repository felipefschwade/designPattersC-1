using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.DesignPatterns.Vendas;

namespace Empresa.DesignPatterns.Impostos
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto(Imposto imposto) : base(imposto) { }
        public ImpostoMuitoAlto() :base() { }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculaOutroImposto(orcamento);
        }
    }
}
