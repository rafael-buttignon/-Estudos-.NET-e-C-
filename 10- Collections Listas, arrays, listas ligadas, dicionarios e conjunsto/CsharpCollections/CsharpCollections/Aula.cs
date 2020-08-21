using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace CsharpCollections
{
    class Aula
    {
        static void Main(string[] args)
        {
            var aulaIntro = new Aulas("Introdução ás Coleções", 20);
            var aulaModelando = new Aulas("Modelando a Classe Aula", 18);
            var aulaSets = new Aulas("Trabalhando com Conjuntos", 16);

            List<Aulas> aulas = new List<Aulas>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            //aulas.Add("Conclusão");

            ImprimirListasObject(aulas);

            aulas.Sort();
            ImprimirListasObject(aulas);

            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            ImprimirListasObject(aulas);

        }

        private static void ImprimirListasObject(List<Aulas> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }

        class Aulas : IComparable
        {
            private string titulo;
            private int tempo;

            public Aulas(string titulo, int tempo)
            {
                this.titulo = titulo;
                this.tempo = tempo;
            }

            public string Titulo { get => titulo; set => titulo = value; }
            public int Tempo { get => tempo; set => tempo = value; }

            public int CompareTo(object obj)
            {
                Aulas that = obj as Aulas;
                return this.titulo.CompareTo(that.titulo);
            }

            public override string ToString()
            {
                
                return $"[Titulo: {titulo}, tempo: {tempo} minutos]";
            }
        }

        private static void AulaDeListas()
        {
            string aulaIntro = "Introdução ás Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //List<string> aulas = new List<string>
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);


            ImprimirListas(aulas);

            Console.WriteLine("A primeira aula é: " + aulas[0]);
            Console.WriteLine("A primeira aula é: " + aulas.First());


            Console.WriteLine("A ultima aula é: " + aulas[aulas.Count - 1]);
            Console.WriteLine("A primeira aula é: " + aulas.Last());

            Console.WriteLine("----------------------");

            aulas[0] = "Trabalhando com Listas";
            ImprimirListas(aulas);

            Console.WriteLine("A primeira aula 'Trabalhando' é: " +
                aulas.First(x => x.Contains("Trabalhando")));

            Console.WriteLine("A ultima aula 'Trabalhando' é: " +
                aulas.Last(x => x.Contains("Trabalhando")));

            Console.WriteLine("A primeira aula 'Conclusão' é: " +
                aulas.FirstOrDefault(x => x.Contains("Conclusão")));

            aulas.Reverse();
            ImprimirListas(aulas);

            aulas.Reverse();
            ImprimirListas(aulas);

            aulas.RemoveAt(aulas.Count - 1);
            ImprimirListas(aulas);

            aulas.Add("Conclusão");
            ImprimirListas(aulas);

            aulas.Sort();
            ImprimirListas(aulas);


            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            ImprimirListas(copia);

            List<string> clone = new List<string>(aulas);
            ImprimirListas(clone);

            clone.RemoveRange(clone.Count - 2, 2);
            ImprimirListas(clone);
        }

        private static void ImprimirListas(List<string> aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //for (int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}
            
            aulas.ForEach(aula => 
            {
                Console.WriteLine(aula);
            });
        }

        private static void AulaDeArrays()
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
            Console.WriteLine(aulas[aulas.Length - 1]);

            aulaIntro = "Trabalhando com Arrays";
            Imprimir(aulas);

            aulas[0] = "Trabalhando com Arrays";
            Imprimir(aulas);

            Console.WriteLine("Aula modelando está no indice " + Array.IndexOf(aulas, aulaModelando));
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
