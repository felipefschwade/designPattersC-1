using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DesignPatterns.Vendas
{
    public class Item
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }

        public Item(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

    }
}
