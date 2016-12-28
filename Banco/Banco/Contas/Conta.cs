using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    public class Conta
    {
        public string Titular { get; private set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }
        public DateTime DataDeCriacao { get; private set; }

        public Conta(int numero, double saldo, string titular, DateTime data)
        {
            Titular = titular;
            Numero = numero;
            Saldo = saldo;
        }
        public override string ToString()
        {
            var str = string.Format("Numero: {0}, Saldo: {1}, Titular: {2}, DataCriacao{3}"
                , Convert.ToString(Numero), Convert.ToString(Saldo), Titular, DataDeCriacao.ToString("dd/MM/yyyy"));
            return str;
        }
    }
}
