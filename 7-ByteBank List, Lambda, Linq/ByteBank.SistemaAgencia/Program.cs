using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(454, 22222),
                new ContaCorrente(452, 99990),
                new ContaCorrente(458, 10000),
                null,
                null,
                null,
                new ContaCorrente(459, 44444),
                new ContaCorrente(400, 99999)
        };

            //contas.Sort(); chama a implementação Icomparable

            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            //IEnumerable<ContaCorrente> contasNaoNulas = contas.Where(conta => conta != null);

            //IOrderedEnumerable<ContaCorrente> contasOrdenadas = contasNaoNulas.OrderBy(conta => conta.Numero);

            var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);
             

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }

        Console.ReadLine();
        }


        static void TestaSortAndVariables()
        {
            var resultado = SomarVarios(1, 5, 9);
            var conta = new ContaCorrente(3434, 34343453);
            var gerenciador = new GerenciadorBonificacao();
            var gerenciadores = new List<GerenciadorBonificacao>();

            var nomes = new List<string>()
            {
                "Guilherme",
                "Rafael",
                "Wellington",
                "Ana"
            };
            nomes.Sort();
            foreach (var nome in nomes)
            {
                Console.WriteLine("Nomes Ordenados: " + nome);
            }


            Lista<int> idades = new Lista<int>();
            List<int> idadesList = new List<int>();

            idadesList.Add(1);
            idadesList.Add(2);
            idadesList.Add(3);
            idadesList.Add(4);
            idadesList.Add(5);

            idadesList.AdicionarVarios(45, 44, 67, 34);
            idadesList.AdicionarVarios(99, -1);

            idadesList.Sort();

            //ListExtensoes.AdicionarVarios(idadesList, 45, 47, 11, 190);
            //idadesList.Remove(4);

            for (int i = 0; i < idadesList.Count; i++)
            {
                Console.WriteLine(idadesList[i]);
            }
        }
        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(15, 16, 17, 19, 20, 16);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];

                Console.WriteLine($"Idade no indice {i} : { idade}");
            }
            Console.ReadLine();
        }
        static void ConsoleDeSomarVarios()
        {
            Console.WriteLine(SomarVarios(1, 2, 3, 4, 5, 6, 7, 8, 143, 143));
            Console.WriteLine(SomarVarios(8, 143, 143));
            Console.WriteLine(SomarVarios(143, 143));
            Console.ReadLine();
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach(int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4456668),
                    new ContaCorrente(874, 7781438)
                };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        static void TestaListaDeContaCorrente()
        {
            //ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(11111, 1111111);
            lista.Adicionar(contaDoGui);
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679754));
            lista.Adicionar(new ContaCorrente(874, 5679445));
            lista.Adicionar(new ContaCorrente(874, 5679445));
            lista.Adicionar(new ContaCorrente(874, 5679445));
            lista.Adicionar(new ContaCorrente(874, 5679445));
            lista.Adicionar(new ContaCorrente(874, 5679445));
            lista.Adicionar(new ContaCorrente(874, 5679445));
            lista.Adicionar(new ContaCorrente(874, 5679445));
            lista.Adicionar(new ContaCorrente(874, 5679445));
            lista.Adicionar(new ContaCorrente(874, 5679445));

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 5679445),
                new ContaCorrente(874, 5679445)
            };

            lista.AdicionarVarios(contas);

            lista.AdicionarVarios(contaDoGui,
                new ContaCorrente(874, 5679445),
                new ContaCorrente(874, 5679445),
                new ContaCorrente(874, 5679445),
                new ContaCorrente(874, 5679445));

            for (int i = 0; i < lista.Tamho; i++)
            {
                ContaCorrente itemAtual = lista.GetItemNoindice(i);

                Console.WriteLine($"Item na posição { i } = Conta { itemAtual.Numero}/{ itemAtual.Agencia}");
            }

        }

        static void TestaArrayInt()
        {
            // ARRAY de inteiros, com 5 posições!
            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }

    }
}
