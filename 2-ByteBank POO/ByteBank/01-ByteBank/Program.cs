  using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabi = new ContaCorrente();

            contaDaGabi.titular = "Gabriela";
            contaDaGabi.agencia = 863;
            contaDaGabi.numero = 876644;
            contaDaGabi.saldo = 100;


            Console.WriteLine(contaDaGabi.titular);
            Console.WriteLine("Agência: " + contaDaGabi.agencia);
            Console.WriteLine("Número: " + contaDaGabi.numero);
            Console.WriteLine("Saldo: " + contaDaGabi.saldo);
            Console.WriteLine();

            contaDaGabi.saldo += 200;
            Console.WriteLine("Novo Saldo " + contaDaGabi.saldo);


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
