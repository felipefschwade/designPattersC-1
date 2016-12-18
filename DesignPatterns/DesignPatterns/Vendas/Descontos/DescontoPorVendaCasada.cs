using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DesignPatterns.Vendas.Descontos
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto proximo { get; set;}

        public double calcula(Orcamento orcamento)
        {
            if (Existe("lapis", orcamento) && Existe("caneta", orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            return proximo.calcula(orcamento);
        }
        private bool Existe(string nome, Orcamento orcamento)
        {
            foreach (Item i in orcamento.Itens)
            {
               if (nome.Equals(i.Nome.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
