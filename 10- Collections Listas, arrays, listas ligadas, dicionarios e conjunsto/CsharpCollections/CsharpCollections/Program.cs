using System;

namespace CsharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução ás Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            string[] aulas = new string[]
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };

            string[] aulas1 = new string[3];
            aulas1[0] = aulaIntro;
            aulas1[1] = aulaModelando;
            aulas[2] = aulaSets;

            Imprimir(aulas);
            Console.WriteLine("--------------");
            Console.WriteLine(aulas[0]);
            Console.WriteLine(aulas[aulas.Length -1]);

            aulaIntro = "Trabalhando com Arrays";
            Imprimir(aulas);

            aulas[0] = "Trabalhando com Arrays";
            Imprimir(aulas);

            Console.WriteLine("Aula modelando está no indice " + Array.IndexOf(aulas,aulaModelando));
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

            Array.Reverse(aulas);
            Imprimir(aulas);

            Array.Reverse(aulas);
            Imprimir(aulas);

            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);

            Array.Sort(aulas);
            Imprimir(aulas);


            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);

            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);

            Array.Clear(clone, 1, 2);
            Imprimir(clone);

        }

        private static void Imprimir(string[] aulas)
        {
            //foreach (var item in aulas)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}
