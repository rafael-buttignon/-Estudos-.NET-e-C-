using System;
using System.Collections.Generic;
using System.Net;

namespace _10_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var messes = new List<string>
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            foreach (var mes in messes)
            {
                Console.WriteLine(mes);
            }

            //O laço foreach pode varrer qualquer coleção que implementa a interface IEnumerable.
        }
    }
}
