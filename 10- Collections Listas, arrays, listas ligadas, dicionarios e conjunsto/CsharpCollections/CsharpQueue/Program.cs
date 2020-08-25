using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpQueue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {

            Enfileirar("Van");
            Enfileirar("Kombi");
            Enfileirar("Guincho");
            Enfileirar("Pickup");

            Console.WriteLine("---------------------------");

            Desenfilerar();
            Desenfilerar();
            Desenfilerar();
            Desenfilerar();
            Desenfilerar();

        }

        private static void Desenfilerar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "Pickup")
                {
                    Console.WriteLine("Pickup Está fazendo o pagamento... ");
                }

                var veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}");
                ImprimirFila();
            }
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: { veiculo }");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("FILA: ");

            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}
