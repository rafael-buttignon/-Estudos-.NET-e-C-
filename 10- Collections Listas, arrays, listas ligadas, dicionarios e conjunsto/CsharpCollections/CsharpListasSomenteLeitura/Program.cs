using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace CsharpListasSomenteLeitura
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aulas("Trabalhando com Listas", 21));
            Imprimir(csharpColecoes.Aulas);

            csharpColecoes.Adiciona(new Aulas("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aulas("Modelando com coleões", 19));

            Imprimir(csharpColecoes.Aulas);
            //csharpColecoes.Aulas.Sort();

            //Ordernar a copia
            List<Aulas> aulasCopiadas = new List<Aulas>(csharpColecoes.Aulas);
            aulasCopiadas.Sort();
            Imprimir(aulasCopiadas);

            //Totalizar o tempo do curso
            Console.WriteLine(csharpColecoes.TempoTotal);

            Console.WriteLine(csharpColecoes);

            //Imprimir detalhes do curso
        }

        private static void Imprimir(IList<Aulas> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
