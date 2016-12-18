using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DesignPatterns.Vendas
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public List<Item> Itens { get; private set; } = new List<Item>();

        public Orcamento(List<Item> itens)
        {
            Valor = itens.Sum(i => i.Preco);
            Itens = itens;
        }
    }
}
