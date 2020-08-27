using System;
using System.Linq;

namespace _8_OperadoresDeConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            //concatenando duas sequencias;
            Console.WriteLine("Concatenando duas sequências");

            var consulta = seq1.Concat(seq2);
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //União de duas sequências
            Console.WriteLine("União de duas sequências");

            var consulta2 = seq1.Union(seq2);

            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //União de duas sequências com comparador
            Console.WriteLine("União de duas sequências com comparador");

            var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);

            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Intersecão entre duas sequencias
            Console.WriteLine("Interseção de duas sequências");

            var consulta4 = seq1.Intersect(seq2);

            foreach (var item in consulta4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Exceto
            Console.WriteLine("Exceto: elemento de seq1 não estão na seq2");

            var consulta5 = seq1.Except(seq2);

            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


        }
    }
}
