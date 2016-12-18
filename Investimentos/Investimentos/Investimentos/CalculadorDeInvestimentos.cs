using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Investimentos.Investimentos
{
    static class CalculadorDeInvestimentos
    {
        public static double CalculaInvestimento(Investimento investimento, double valor)
        {
            var rendimento = investimento.Calcula(valor);
            return valor + (rendimento - rendimento * 0.25);
        }
    }
}
