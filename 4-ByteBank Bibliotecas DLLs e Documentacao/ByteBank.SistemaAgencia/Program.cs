using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(854, 3423443);

            Console.WriteLine(conta.Numero);
            Console.ReadLine();
        }
    }
}
