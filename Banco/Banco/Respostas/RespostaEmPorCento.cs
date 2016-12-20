using Banco.Contas;
using Banco.Requisicoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Respostas
{
    class RespostaEmPorCento : Resposta
    {
        public Resposta proxima { get; set; }

        public void Responde(Requisicao Req, Conta conta)
        {
            if (Req.Formato == Formato.PORCENTO)
            {
                var msg = string.Format("Titular{0}%Saldo{1}%Numero>{2}",
                                        conta.Titular, Convert.ToString(conta.Saldo), Convert.ToString(conta.Numero));
                Console.WriteLine(msg);
            }
            else
            {
                proxima.Responde(Req, conta);
            }
        }
    }
}
