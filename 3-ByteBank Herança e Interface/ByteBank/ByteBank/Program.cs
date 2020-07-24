using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBoneficacao gerenciador = new GerenciadorBoneficacao();


            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "784.224.664.20";
            carlos.Salario = 2000;

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "843.543.20";
            roberta.Salario = 5000;

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de um referencia de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de um referencia de Diretor: " + robertaTeste.GetBonificacao());


            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);


            Console.WriteLine(roberta.Nome); ;
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine(carlos.Nome); ;
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine("Total de Bonificações: " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();
        }
    }
}
