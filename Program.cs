using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONTA BANCÁRIA");
            Console.WriteLine("===============");
            Console.WriteLine();

            double valor = 0.00;

            Console.Write("Digite o Número da Conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Digite o Nome do Titular da Conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá Depósito Inicial: (s)/(n)");
            string check = Console.ReadLine();
            if (check == "s")
            {
                Console.Write("Entre com valor do Depósito Inicial: R$ ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            
            Conta con = new Conta(conta, titular, valor);

            Console.WriteLine(con);
                
        }
    }
}
