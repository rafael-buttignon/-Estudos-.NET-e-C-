using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_OutrosOperadoresLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mes> messes = new List<Mes>
            {
                new Mes("Janeiro", 31),
                new Mes("Fevereiro", 28),
                new Mes("Março", 31),
                new Mes("Abril", 30),
                new Mes("Maio", 31),
                new Mes("Junho", 30),
                new Mes("Julho", 31),
                new Mes("Agosto", 31),
                new Mes("Setembro", 30),
                new Mes("Outubro", 31),
                new Mes("Novembro", 30),
                new Mes("Dezembro", 31)
            };

            // Pegar o primeiro trimestre
            var consulta = messes.Take(3);

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Pegar os meses depois do primeiro trimestre

            var consulta2 = messes.Skip(3);

            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Pegar os messes do treceiro trimestre

            var consulta3 = messes.Skip(6).Take(3);

            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Pegar os meses até que o mês comece com a letra 'S'

            var consulta4 = messes.TakeWhile(m => !m.Nome.StartsWith("S"));

            foreach (var item in consulta4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // Pular os messes até que o mês comece com a letra 'S'
            var consulta5 = messes.SkipWhile(m => !m.Nome.StartsWith("S"));

            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        class Mes
        {
            public Mes(string nome, int dias)
            {
                Nome = nome;
                Dias = dias;
            }

            public string Nome { get; private set; }
            public int Dias { get; private set; }

            public override string ToString()
            {

                return $"{Nome} - {Dias}";
            }
        }
    }
}
