using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;
using Banco.Requisicoes;

namespace Banco.Respostas
{
    class RespostaEmXML : Resposta
    {
        public Resposta proxima { get; set; } = null;

        public void Responde(Requisicao Req, Conta conta)
        {
            if (Req.Formato == Formato.XML)
            {
                var msg = string.Format("<Conta><Titular>{0}</Titular><Saldo>{1}</Saldo><Numero>{2}</Numero></Conta>",
                                        conta.Titular, Convert.ToString(conta.Saldo), Convert.ToString(conta.Numero));
                Console.WriteLine(msg);
            }
            else if (proxima != null)
            {
                proxima.Responde(Req, conta);
            }
            else
            {
                throw new ArgumentException("Tipo de resposta inválido");
            }
        }
    }
}
