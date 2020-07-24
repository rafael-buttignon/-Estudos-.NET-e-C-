using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBoneficacao gerenciadorBoneficacao = new GerenciadorBoneficacao();

            Designer pedro = new Designer(3000, "833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor(5000, "159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar(2000, "445.112.664-11");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta(4000, "234.632.622-01");
            camila.Nome = "Camila";

            gerenciadorBoneficacao.Registrar(pedro);
            gerenciadorBoneficacao.Registrar(roberta);
            gerenciadorBoneficacao.Registrar(igor);
            gerenciadorBoneficacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " + gerenciadorBoneficacao.GetTotalBonificacao());



        }
    }
}
