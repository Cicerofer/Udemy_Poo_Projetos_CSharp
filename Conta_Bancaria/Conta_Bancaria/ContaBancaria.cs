using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Conta_Bancaria
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this (numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5;
        }


        public override string ToString()
        {
            return "Conta "
                + Numero 
                + ", Titular: " 
                + Titular 
                + ", Saldo: R$ " +
                Saldo.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }

    /*Em um banco,para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do titular da conta,
     entretant, é opcional, ouseja: se o titular não tiver dinheiro a depositar no momento de abrir sua conta, depósito incial não será feito e o saldo será, naturalmente, zero.
        Importante: uma vez que uma conta bancária foi aberta , o número da conta nunca poderá ser alterado.
    já o nome do titular pode ser alterado ( pois uma pessoa pode mudar de nome por ocas´~ao de casamento, por exemplo.
        
        Por fim, o saldo da conta não pode ser alterado livremente. è preciso haver um mecanismo para proteger isso. O saldo só aumenta por meio
    de depósitos, e só diminui por de saques. Para cada saque realizado, o banco cobra uma taxa de R$ 5.00, Nota: a conta pode ficar com saldo negativo se o saldo não for
    suficiente para realizar o saque e/ou pagar a taxa.
    
        Você deve fazer um programa que realize o cadastro de uma conta, dando opção para seja ou não informado o valor de depósito inicial.
    Em seguida, realizar um depósito e depois um saque, sempre mostrando os dados da conta após cada operação.)*/
}
