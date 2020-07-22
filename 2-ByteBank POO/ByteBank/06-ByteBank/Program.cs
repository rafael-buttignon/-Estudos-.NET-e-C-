using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.Cpf = "434.565.566.30";
            cliente.Profissao = "Programador";


            conta.Titular = cliente;
            conta.SetSaldo(-10);

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.GetSaldo());

            Console.ReadLine();
        }
    }
}
