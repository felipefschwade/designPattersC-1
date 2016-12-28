using Banco.Contas;
using Banco.Respostas;
using Banco.Requisicoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Relatorios;
using Banco.Filtros;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            var Contas = new List<Conta>();
            for (int i = 0; i < 10; i++)
            {
                var c = new Conta(i, i + 10 * i, Convert.ToString(i), DateTime.Now);
                Contas.Add(c);
            }
            Contas.Add(new Conta(13, 600000, "Delfo", new DateTime(2016, 11, 30)));
            Contas.Add(new Conta(14, 150000, "Felipe", new DateTime(2016, 11, 30)));
            var rc = new RelatorioComplexo();
            var rs = new RelatorioSimples();
            rc.Imprime(Contas);
            rs.Imprime(Contas);
            var r1 = new RespostaEmCSV();
            var r2 = new RespostaEmPorCento();
            var r3 = new RespostaEmXML();
            r1.proxima = r2;
            r2.proxima = r3;
            Filtro filtro = new ContasComMenosDe100Reais(new FiltroMaisDe500KDeSaldo(new FiltroMesCorrente()));
            var filtradas = filtro.Filtra(Contas);
            filtradas.ToList().ForEach(c => Console.WriteLine(c));
            Console.ReadKey();

        }
    }
}
