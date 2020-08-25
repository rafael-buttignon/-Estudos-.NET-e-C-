using CsharpListasSomenteLeitura;
using System;
using System.Collections.Generic;

namespace CsharpPoderDosSets
{
    class Program
    {
        static void Main(string[] args)
        {

            Curso csharpColecoes = new Curso("C# Colecoes", "Marrcelo Oliveira");
            csharpColecoes.Adiciona(new Aulas("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aulas("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aulas("Modelando com Coleções", 24));
            csharpColecoes = new Curso("C# LOOP", "Rfael");
            csharpColecoes.Adiciona(new Aulas("1", 1));


            Aluno a1 = new Aluno("Vanessa Tonini", 34545);
            Aluno a2 = new Aluno("Ana Losnak", 43455);
            Aluno a3 = new Aluno("Rafael Nercessian", 14545);

            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);


            Console.WriteLine("Imprimindo os alunos matriculados!");

            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }
            
            Console.WriteLine($"O Aluno a1 {a1.Nome} esta matriculado");

            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            Aluno tonini = new Aluno("Vanessa Tonini", 34545);

            Console.WriteLine("Tonini está matriculado: " + csharpColecoes.EstaMatriculado(tonini));

            Console.WriteLine("a1 == a Tonini");
            Console.WriteLine(a1 == tonini);

            Console.WriteLine("a1 e equals a Tonini");
            Console.WriteLine(a1.Equals(tonini));

            Console.Clear();

            Console.WriteLine("Quem é o aluno com a matricula 34545");

            Aluno aluno34545 = csharpColecoes.BuscaMatriculado(34545);

            Console.WriteLine("aluno34545: " + aluno34545);


            Console.WriteLine("Quem é o aluno com a matricula 5618");
            Console.WriteLine(csharpColecoes.BuscaMatriculado(5618));

            Aluno fabio = new Aluno("Fabio", 34545);
            //csharpColecoes.Matricula(fabio); // o dicionario não deixa adicionar outro aluno com a mesma  matricula

            csharpColecoes.SubstrituiAluno(fabio);


            Console.WriteLine("Quem é o aluno com a matricula 34545 agora ");
            Console.WriteLine(csharpColecoes.BuscaMatriculado(34545));
        }

        private static void SimpleTestSets()
        {

            //SETS = CONJUNTOS

            // DUAS propriedades do Set
            //1. não permite duplicidade
            //2. os elementos não são mantidos em ordem especifica

            // declando set de alunos

            ISet<string> alunos = new HashSet<string>();
            // adicionando: vanessa, ana, rafael

            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Buttignon");

            Console.WriteLine(string.Join(", ", alunos));

            // diferança para uma lista
            // adicionando: priscila, rollo, fabio
            alunos.Add("Priscila Studani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushinik");

            Console.WriteLine(string.Join(", ", alunos));


            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");

            Console.WriteLine(string.Join(", ", alunos));

            alunos.Add("Fabio Gushinik");
            Console.WriteLine(string.Join(", ", alunos));


            // qual a vatagem do set sobre a lista look-up!
            // desempenho HashSet x List : escalabilidade X memória

            List<string> alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();

            Console.WriteLine(string.Join(", ", alunosEmLista));
        }
    }
}
