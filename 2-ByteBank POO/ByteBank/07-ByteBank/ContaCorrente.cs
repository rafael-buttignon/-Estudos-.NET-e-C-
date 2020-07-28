﻿using _07_ByteBank;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        public int Agencia { get; }
        public int Numero { get; }

        private double saldo = 100;

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public void SetSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }
            this.saldo = saldo;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo < valor)
                return false;
            else
            {
                saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

         public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TaxaOperacao = 30 / TotalDeContasCriadas;

            TotalDeContasCriadas++;
        }
    }
}
