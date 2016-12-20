using Banco.Contas;
using Banco.Requisicoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Respostas
{
    interface Resposta
    {
        Resposta proxima { get; set; }
        void Responde(Requisicao Req, Conta conta);
    }
}
