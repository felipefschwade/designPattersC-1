using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DesignPatterns.Vendas.Descontos
{
    class SemDesconto : Desconto
    {
        public Desconto Proximo { get; set; }

        public double calcula(Orcamento orcamento)
        {
            return 0;
        }
    }
}
