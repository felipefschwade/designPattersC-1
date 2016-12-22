using Banco.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Relatorios
{
    public abstract class TemplateRelatorio
    {
        public void Imprime(IList<Conta> contas)
        {
            Console.WriteLine(Cabecalho());
            Corpo(contas);
            Console.WriteLine(Rodape());
        }
        protected abstract string Cabecalho();
        protected abstract void Corpo(IList<Conta> contas);
        protected abstract string Rodape();
    }
}
