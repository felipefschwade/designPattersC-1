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
       
        public Conta(int numero, double saldo, string titular)
        {
            Titular = titular;
            Numero = numero;
            Saldo = saldo;
        }
    }
}
