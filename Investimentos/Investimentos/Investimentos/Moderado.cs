using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Investimentos.Investimentos
{
    public class Moderado : Investimento
    {
        string Nome = "Moderado";

        public double Calcula(double valor)
        {
            var rand = new Random().Next(101);
            if (rand < 50)
            {
                return valor * 0.007;
            }
            return valor * 0.025;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
