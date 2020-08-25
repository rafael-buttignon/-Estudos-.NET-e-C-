using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace _3_CsharpCollectionsSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };

            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("FABIO GUSHIKEN");

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            ISet<string> outroConjunto = new HashSet<string>();

            //este conjunto é subconjunto do outroConjunto - IsSubSetOf
            alunos.IsSubsetOf(outroConjunto);

            //este conjunto e superconjunto do outroConjunto - IsSuperSetOf
            alunos.IsSupersetOf(outroConjunto);

            //os conjuntos contêm os mesmo elemtnos - SetEquals
            alunos.SetEquals(outroConjunto);

            //substrai os elementos da outra coleção que também estão no conjunto
            alunos.ExceptWith(outroConjunto);

            //intersecção dos conjuntos - intersectWith
            alunos.IntersectWith(outroConjunto);

            //somente em um ou outro conjunt - SymmetricExceptWith
            alunos.SymmetricExceptWith(outroConjunto);

            //união de conjuntos - UnionWith
            alunos.UnionWith(outroConjunto);
        }
    }

    internal class ComparadorMinusculo : IComparer<string>
    {
        public int Compare([AllowNull] string x, [AllowNull] string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
