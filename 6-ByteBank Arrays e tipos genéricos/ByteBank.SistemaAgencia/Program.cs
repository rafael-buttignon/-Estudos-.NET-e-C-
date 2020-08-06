using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.Adicionar(new ContaCorrente(5667, 534343));
            lista.Adicionar(new ContaCorrente(5667, 454545));
            lista.Adicionar(new ContaCorrente(5667, 534343));
            lista.Adicionar(new ContaCorrente(5667, 534343));
            lista.Adicionar(new ContaCorrente(5667, 454545));
            lista.Adicionar(new ContaCorrente(5667, 534343));
            lista.Adicionar(new ContaCorrente(5667, 534343));
            lista.Adicionar(new ContaCorrente(5667, 454545));
            lista.Adicionar(new ContaCorrente(5667, 534343));
            lista.Adicionar(new ContaCorrente(5667, 534343));
            lista.Adicionar(new ContaCorrente(5667, 454545));
            lista.Adicionar(new ContaCorrente(5667, 534343));

            Console.ReadLine();
        }

        static void testaArrayConta()
        {
            ContaCorrente[] contas = new ContaCorrente[]
{
                new ContaCorrente(5667, 534343),
                new ContaCorrente(5667, 454545),
                new ContaCorrente(5667, 565678)
};


            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta { indice } { contaAtual.Numero} ");
            }
        }

        static void testaArrayInt()
        {
            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades no {indice} = {idade}");
                acumulador += idade;
            }
            int media = acumulador / idades.Length;
            Console.WriteLine("-------------------------");
            Console.WriteLine("Media de idades: " + media);

        }
    }
}
