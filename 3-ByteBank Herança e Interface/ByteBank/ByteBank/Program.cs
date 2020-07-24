using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario(1);

            carlos.Nome = "Carlos";
            carlos.CPF = "784.224.664.20";
            carlos.Salario = 2000;


            Console.WriteLine(carlos.Nome); ;
            Console.WriteLine(carlos.GetBonificacao());
            Console.ReadLine();
        }
    }
}
