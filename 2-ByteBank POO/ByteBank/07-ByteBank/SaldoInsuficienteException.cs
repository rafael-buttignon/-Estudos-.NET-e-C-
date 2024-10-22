﻿using System;

namespace _07_ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentavia de saque do valor de " + valorSaque + " em uma conta com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string message, Exception exceptionInterna)
            : base(message, exceptionInterna)
        {

        }

        public SaldoInsuficienteException(string message)
            : base(message)
        {

        }
    }
}
