using System;
using System.Globalization;

namespace ListaDeExercicios07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o numero da conta: ");
            int nConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o Titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n): ");
            char resp = char.Parse(Console.ReadLine());
            double valorDeposito;
            Conta conta;
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(nConta,titular,valorDeposito);
            } else
            {
                conta = new Conta(nConta,titular);
            }

            Console.WriteLine($"\nDados da conta:\n{conta}\n");

            Console.Write("Entre um valor para deposito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor);

            Console.WriteLine($"\nDados da conta atualizados:\n{conta}\n");

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);

            Console.WriteLine($"\nDados da conta atualizados:\n{conta}\n");
        }
    }
}