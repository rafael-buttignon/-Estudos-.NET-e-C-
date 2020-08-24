using CsharpPoderDosSets;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CsharpListasSomenteLeitura
{
    public class Curso
    {
        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        private IList<Aulas> aulas;

        public IList<Aulas> Aulas
        {
            get { return new ReadOnlyCollection<Aulas>(aulas); }
        }

        internal void Adiciona(Aulas aulas)
        {
            this.aulas.Add(aulas);
        }

        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aulas>();
        }

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
            this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public int TempoTotal
        {
            get 
            {
                //int total = 0;
                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}
                //return total;

                //LINQ = LANGUAGE INTEGRATED QUERY 
                // CONSULTA INTEGRADA Á LINGUAGEM

                return aulas.Sum(aula => aula.Tempo);
            }
        }

        internal Aluno BuscaMatriculado(int numeroMatriculada)
        {
            Aluno aluno = null;
            this.dicionarioAlunos.TryGetValue(numeroMatriculada, out aluno);
            return aluno;
        }

        internal void SubstrituiAluno(Aluno aluno)
        {
            this.dicionarioAlunos[aluno.NumeroMatricula] = aluno;
        }

        public override string ToString()
        {
            return $"Curso: {nome} , Tempo: {TempoTotal} , Aulas: { string.Join(", ", aulas)} ";
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }


    }
}
