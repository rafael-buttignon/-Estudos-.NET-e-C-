using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.String;
using static System.DateTime;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.IO;

namespace CSharp6.R09
{
    class Programa
    {
        public async void Main()
        {
                WriteLine("9. Filtros De Exceção");
                StreamWriter logAplicacao = new StreamWriter("LogAplicacao.txt");

            try
            {
                await logAplicacao.WriteLineAsync("Aplicação esta iniciando...");
                Aluno aluno = new Aluno("Marty", "Hill", new DateTime(1999, 12, 06))
                { Endereco = "9303 Lyon Driver Hill Valey Ca", Telefone = "444-45643" };


                await logAplicacao.WriteLineAsync("Aluno marty Hill foi criado...");

                WriteLine(aluno.Nome);
                WriteLine(aluno.Sobrenome);
                WriteLine(aluno.NomeCompleto);

                WriteLine("Idade: {0}", aluno.GetIdade());
                WriteLine(aluno.DadosPessoais);

                aluno.AdicionarAvaliacao(new Avaliacao(1, "Geografia", 8.0));
                aluno.AdicionarAvaliacao(new Avaliacao(1, "Historia", 9.0));
                aluno.AdicionarAvaliacao(new Avaliacao(1, "Matemática", 7.0));

                Aluno aluno2 = new Aluno("Bart", "Simpson");

                await logAplicacao.WriteLineAsync("Aluno Bart Simpson foi criado...");

                ImprimirMelhorNota(aluno);
                ImprimirMelhorNota(aluno2);

                aluno.PropertyChanged += Aluno_PropertyChanged;

                aluno.Endereco = "Rua Vergueiro, 3185";
                aluno.Telefone = "555-1234";

                Aluno aluno3 = new Aluno("Charlie", "");
                await logAplicacao.WriteLineAsync("Aluno Charilie Brown foi criado...");


            }
            catch (ArgumentException ex) when (ex.Message.Contains("não informado"))
            {
                string msg = $"Paramêtro { ex.ParamName } não foi informado!";
                await logAplicacao.WriteLineAsync(msg);
                Console.WriteLine(msg);
            }
            catch (ArgumentException ex)
            {
                string msg = "Parâmetro com problema!";
                await logAplicacao.WriteLineAsync(msg);
                Console.WriteLine(msg);

            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
                await logAplicacao.WriteLineAsync(msg);
                Console.WriteLine(msg);
            }
            finally
            {
                await logAplicacao.WriteLineAsync("Aplicação terminou.");
                logAplicacao.Dispose();
            }

        }

        private void Aluno_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine($"Propriedade {e.PropertyName} foi alterada!");
        }

        private static void ImprimirMelhorNota(Aluno aluno)
        {
            Console.WriteLine("Melhor nota: {0} ", aluno?.MelhorAvaliacao?.Nota);
        }

        class Aluno : INotifyPropertyChanged
        {
            public string Nome { get; }
            public string Sobrenome { get; }
            //public string Endereco { get; set; }
            //public string Telefone { get; set; }
            private string endereco;

            public string Endereco
            {
                get { return endereco; }

                set
                {
                    if (endereco != value)
                    {
                        endereco = value;
                        OnPropertyChanged();
                        OnPropertyChanged(nameof(DadosPessoais));
                    }
                }
            }

            private void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            private string telefone;

            public string Telefone
            {
                get { return telefone; }

                set
                {
                    if (telefone != value)
                    {
                        telefone = value;
                        OnPropertyChanged();
                        OnPropertyChanged(nameof(DadosPessoais));
                    }
                }
            }

            public string DadosPessoais => $"Nome: {NomeCompleto}, Endereco: {Endereco}, Telefone: {Telefone}, Data Nascimento: {DataNascimento: dd/MM/yyyy}";
            public DateTime DataNascimento { get; } = new DateTime(1999, 12, 06);
            public string NomeCompleto => Nome + " " + Sobrenome;
            public int GetIdade() => (int)(((Now - DataNascimento).TotalDays) / 365.242199);

            public Aluno(string nome, string sobrenome)
            {
                VerificarParametroPrenchido(nome, nameof(nome));
                VerificarParametroPrenchido(sobrenome, nameof(sobrenome));

                Nome = nome;
                Sobrenome = sobrenome;
            }

            private static void VerificarParametroPrenchido(string valorParametro, string nomeParametro)
            {
                if (IsNullOrEmpty(valorParametro))
                {
                    throw new ArgumentException("Parametro não informado", nameof(nomeParametro));
                }
            }

            public Aluno(string nome, string sobrenome, DateTime dataNascimento)
                : this(nome, sobrenome)
            {
                this.DataNascimento = dataNascimento;
            }
            private IList<Avaliacao> avaliacoes = new List<Avaliacao>();

            public event PropertyChangedEventHandler PropertyChanged;

            public IReadOnlyCollection<Avaliacao> Avaliacoes => new ReadOnlyCollection<Avaliacao>(avaliacoes);

            public void AdicionarAvaliacao(Avaliacao avaliacao)
            {
                avaliacoes.Add(avaliacao);
            }
            public Avaliacao MelhorAvaliacao => avaliacoes.OrderBy(a => a.Nota).LastOrDefault();
        }

        class Avaliacao
        {
            public Avaliacao(int bimestre, string materia, double nota)
            {
                Bimestre = bimestre;
                Materia = materia;
                Nota = nota;
            }

            public int Bimestre { get; }
            public string Materia { get; }
            public double Nota { get; }
        }
    }
}
