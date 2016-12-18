using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Investimentos.Investimentos
{
    public class Arrojado : Investimento
    {
        string Nome = "Arrojado";

        public double Calcula(double valor)
        {
            var rand = new Random().Next(101);
            if (rand < 50)
            {
                return valor * 0.006;
            }
            if (rand >= 50 && rand <= 80)
            {
                return valor * 0.03;
            }
            return valor * 0.05;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
