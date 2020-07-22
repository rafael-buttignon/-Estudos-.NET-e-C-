using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Programadora";
            gabriela.cpf = "24454545466";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = gabriela;
            conta.agencia = 563;
            conta.saldo = 500;
            conta.numero = 5664234;

            conta.titular.nome = "Gabriela Costa";

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
