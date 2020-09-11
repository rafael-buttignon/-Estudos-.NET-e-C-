using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.String;
using static System.DateTime;

namespace CSharp6.R04
{
    class Programa
    {
        public void Main()
        {
            WriteLine("4. Using Static");

            Aluno aluno = new Aluno("Marty", "McFly", new DateTime(1999, 12, 06))
            { Endereco = "9303 Lyon Driver Hill Valey Ca", Telefone = "444-45643"};

            WriteLine(aluno.Nome);
            WriteLine(aluno.Sobrenome);
            WriteLine(aluno.NomeCompleto);

            WriteLine("Idade: {0}", aluno.GetIdade());
            WriteLine(aluno.DadosPessoais);
        }

        class Aluno
        {
            public string Nome { get; }
            public string Sobrenome { get; }
            public string Endereco { get; set; }
            public string Telefone { get; set; }
            public string DadosPessoais => Format("{0}, {1}, {2}", NomeCompleto, Endereco, Telefone);
            public DateTime DataNascimento { get; } = new DateTime(1999, 06, 12);
            public string NomeCompleto => Nome + " " + Sobrenome;
            public int GetIdade() => (int)(((Now - DataNascimento).TotalDays) / 365.242199);

            public Aluno(string nome, string sobrenome)
            {
                Nome = nome;
                Sobrenome = sobrenome;
            }
            public Aluno(string nome, string sobrenome, DateTime dataNascimento)
                : this(nome, sobrenome)
            {
                this.DataNascimento = dataNascimento;
            }

        }
    }
}