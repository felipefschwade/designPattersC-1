using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DesignPatterns.Vendas.Descontos
{
    public class CalculadorDeDescontos
    {
        public Desconto[] Descontos { get; private set; } = new Desconto[10];

        public CalculadorDeDescontos()
        {
            Descontos[3] = new SemDesconto();
            Descontos[2] = new DescontoPorVendaCasada(Descontos[3]);
            Descontos[1] = new DescontoParaMaisDe500Reais(Descontos[2]);
            Descontos[0] = new DescontoParaMaisDe10Itens(Descontos[1]);

        }
        public double Calcula(Orcamento orcamento)
        {
            return Descontos[0].calcula(orcamento);   
        }
    }
}
