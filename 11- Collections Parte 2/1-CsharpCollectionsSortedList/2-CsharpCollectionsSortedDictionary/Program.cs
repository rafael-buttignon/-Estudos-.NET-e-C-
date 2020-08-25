using _1_CsharpCollectionsSortedList;
using System;
using System.Collections.Generic;

namespace _2_CsharpCollectionsSortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Aluno> sorted = new SortedDictionary<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

            //Uma SortedDictionary é mais adequada se você precisa inserir / remover elementos 
            //    com muita frequência, pois essas operações são otimizadas pela sua estrutura 
            //    interna de árvore binária balanceada.
        }
    }
}
