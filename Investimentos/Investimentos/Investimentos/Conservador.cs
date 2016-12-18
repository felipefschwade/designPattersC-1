using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Investimentos.Investimentos
{
    public class Conservador : Investimento
    {
        string Nome = "Conservador";
        public double Calcula(double valor)
        {
            return valor * 0.008;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
