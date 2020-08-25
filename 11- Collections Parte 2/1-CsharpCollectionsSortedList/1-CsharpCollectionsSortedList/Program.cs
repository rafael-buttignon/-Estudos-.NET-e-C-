using System;
using System.Collections.Generic;

namespace _1_CsharpCollectionsSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("---------------");

            alunos.Remove("AL");

            alunos.Add("MO", new Aluno("Marcelo", 12345));

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            Console.WriteLine("---------------");


            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

        }
    }
}
