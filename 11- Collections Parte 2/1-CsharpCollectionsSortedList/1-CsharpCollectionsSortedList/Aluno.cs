using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_CsharpCollectionsSortedList
{
    public class Aluno
    {
        private string nome;
        private int numeroMatricula;

        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public int NumeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }

        public override string ToString()
        {

            return $"[Nome: { Nome }, Matricula: { NumeroMatricula }]";
        }

        public override bool Equals(object obj)
        {
            Aluno outroObj = obj as Aluno;

            if (outroObj == null)
            {
                return false;
            }

            return this.nome.Equals(outroObj.nome);
        }

        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }
    }
}
