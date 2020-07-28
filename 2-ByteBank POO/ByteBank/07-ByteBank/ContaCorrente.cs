using _07_ByteBank;
using System;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        public int Agencia { get; }
        public int Numero { get; }

        private double Saldo = 100;

        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (Saldo < valor)
            {
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public double GetSaldo()
        {
            return Saldo;
        }

        public void SetSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }
            this.Saldo = saldo;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferencia.", nameof(valor));
            }
             Sacar(valor);
             contaDestino.Depositar(valor);
        }

         public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0)
            {
                throw new ArgumentException("O Argumento Agencia deve ser maior que 0. ", nameof(agencia));
            }
            if(numero <= 0)
            {
                throw new ArgumentException("O Argumento Numero deve ser maior que 0. ", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }
    }
}
