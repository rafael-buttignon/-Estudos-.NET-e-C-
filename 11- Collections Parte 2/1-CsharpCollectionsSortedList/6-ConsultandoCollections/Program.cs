using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;

namespace _6_ConsultandoCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var exemplo = "";
            if (!string.IsNullOrEmpty(exemplo))
            {
                //a condição deve ser false(por conta do !) para prosseguir
                //ele verifica a variável, como nesse caso ela tem valor, o IsNullOrEmpty irá
                //retornar false, pois não é null nem empty a variavel
                Console.WriteLine("entrou");
            }
            var exemplo2 = "1";
            if (string.IsNullOrEmpty(exemplo2))
            {
                //a condição deve ser true para prosseguir
                //se a variavel exemplo for null ou empty, irá satisfazer a condição do If
                //pois a condição pede que o valor seja null ou empty
                Console.WriteLine("entrou222222222222222");
            }

            //PROBLEMA: obter os nomes dos messes do ano, 
            //que tem 31 dias em minusculo e em ordem alfabética

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

            //messes.Sort();
            //foreach (var mes in messes)
            //{
            //    if(mes.Dias == 31)
            //    {
            //        Console.WriteLine(mes.Nome.ToUpper());
            //    }
            //}

            //LINQ = Consulta integrada á linguagem.
            //MONTAGEM DA CONSULTA

            IEnumerable<string> 
                consulta = messes
                .Where(m => m.Dias == 31)
                .OrderBy(m => m.Nome)
                .Select(m => m.Nome.ToUpper());


            //UTILIZAÇÃO DA CONSULTA
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

        }
    }

    class Mes //: IComparable
    {
        public Mes(string nome, int dias)
        {
            Nome = nome;
            Dias = dias;
        }

        public string Nome { get; private set; }
        public int Dias { get; private set; }

        //public int CompareTo(object obj)
        //{
        //    Mes outro = obj as Mes;

        //    return this.Nome.CompareTo(outro.Nome);
        //}

        public override string ToString()
        {

            return $"{Nome} - {Dias}";
        }
    }
}
