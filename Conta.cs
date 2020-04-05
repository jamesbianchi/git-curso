using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public int _conta ;
        public string _titular;
        public double Saldo;

        public Conta()
        {

        }

        public Conta(int conta, string titular, double valor)
        {
            _conta = conta;
            _titular = titular;
            Saldo = valor;
        }

        public override string ToString()
        {
            return "Conta Corrente: " + _conta
                + " Nome do Titular: "+ _titular 
                + " Saldo da Conta : R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture) ;
        }
    }


}
