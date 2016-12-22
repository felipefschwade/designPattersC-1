using Banco.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Relatorios
{
    class RelatorioComplexo : TemplateRelatorio
    {
        protected override string Cabecalho()
        {
            return "Banco Ficticio \n Telefone: 123123123 \n Endereço: blablabla";
        }

        protected override void Corpo(IList<Conta> contas)
        {
            contas.ToList().ForEach(c => {
                var str = string.Format("Titular: {0} Numero:{1} Saldo:{2}", c.Titular, Convert.ToString(c.Numero), Convert.ToString(c.Saldo));
                Console.WriteLine(str);
            });
        }

        protected override string Rodape()
        {
            DateTime data = DateTime.Now;
            return "Banco Ficticio \t Telefone: 123123123" + data.ToString("D");
        }
    }
}
