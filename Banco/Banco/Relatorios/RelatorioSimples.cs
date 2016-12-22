using Banco.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Relatorios
{
    class RelatorioSimples : TemplateRelatorio
    {
        protected override string Cabecalho()
        {
            return "Banco Ficticio \t Telefone: 123123123";
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (var conta in contas)
            {
                var str = string.Format("Titular: {0} Saldo: {1}", conta.Titular, Convert.ToString(conta.Saldo));
                Console.WriteLine(str);
            }
        }

        protected override string Rodape()
        {
            return "Banco Ficticio \t Telefone: 123123123";
        }
    }
}
