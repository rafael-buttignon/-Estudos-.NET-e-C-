using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente conta = new ContaCorrente(854, 3423443);
            //Funcionario funcionario = null;

            //Console.WriteLine(conta.Numero);

            DateTime dataFimPagamento = new DateTime(2020, 12, 06);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;
            TimeSpan diferencateste = TimeSpan.FromMinutes(60);

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            string mensagem1 = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferencateste);


            Console.WriteLine(mensagem);
            Console.WriteLine(mensagem1);


            Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);

            Console.ReadLine();
        }

    }
}
