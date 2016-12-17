using Empresa.DesignPatterns.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DesignPatterns.Impostos
{
    public interface Imposto
    {
        double Calcula(Orcamento orcamento);
    }
}
