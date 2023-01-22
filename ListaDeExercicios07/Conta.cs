using System;
using System.Globalization;
namespace ListaDeExercicios07
{
    internal class Conta
    {
        // Atributos privados
        public int NumeroConta { get; private set; }
        // Propriedades autoimplementadas
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        // Construtores
        public Conta(int numeroConta,string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }
        public Conta(int numeroConta,string titular,double depositoInicial) : this(numeroConta, titular) 
        {
            Deposito(depositoInicial);
        }
        // Outros metodos
        public void Saque(double valorSaque)
        {
            Saldo = Saldo - valorSaque - 5.00;
        }

        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Titular}, Saldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
