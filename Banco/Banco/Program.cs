using Banco.Contas;
using Banco.Respostas;
using Banco.Requisicoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Conta(1, 120.00, "Felipe");
            var r1 = new RespostaEmCSV();
            var r2 = new RespostaEmPorCento();
            var r3 = new RespostaEmXML();
            r1.proxima = r2;
            r2.proxima = r3;

            var Requisicao = new Requisicao(Formato.PORCENTO);
            r1.Responde(Requisicao, c);
            Console.ReadKey();

        }
    }
}
