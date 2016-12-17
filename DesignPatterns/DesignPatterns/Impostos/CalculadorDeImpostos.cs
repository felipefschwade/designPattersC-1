using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.DesignPatterns.Vendas;

namespace Empresa.DesignPatterns.Impostos
{
    public class CalculadorDeImpostos
    {
        public double CalcularImposto(Orcamento orcamento, Imposto imposto)
        {
            return imposto.Calcula(orcamento);
        }
    }
}
