using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DesignPatterns.Vendas.Descontos
{
    public interface Desconto
    {
        Desconto Proximo { set; get;}
        double calcula(Orcamento orcamento);
    }
}
