using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 7451854);
            Console.WriteLine("Conta Numero: " + ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 8458454);

            Console.WriteLine(contaDaGabriela.Agencia);
            Console.WriteLine(contaDaGabriela.Numero);


            Console.WriteLine("Conta Numero: " + ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
