using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(854, 3423443);
            Funcionario funcionario = null;

            Console.WriteLine(conta.Numero);
            Console.ReadLine();
        }
    }
}
