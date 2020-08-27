using System;
using System.Collections.Generic;
using System.Net;

namespace _9_Covariancia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string para object");

            string titulo = "messes";
            object obj = titulo;

            Console.WriteLine(obj);

            Console.WriteLine();

            Console.WriteLine("List<string> para List<object>");

            IList<string> listaMeses = new List<string>
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            //IList<object> listaObj = listaMeses;
            Console.WriteLine();
            
            Console.WriteLine("string[] para object[]");
            string[] arrayMeses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            object[] arrayObj = arrayMeses; //COVARIÂNCIA!
            Console.WriteLine(arrayObj);

            foreach (var item in arrayObj)
            {
                Console.WriteLine(item);
            }

            arrayObj[0] = "PRIMEIRO MÊS";
            Console.WriteLine(arrayObj[0]);
            Console.WriteLine();


            //arrayObj[0] = 12345;
            //Console.WriteLine(arrayObj[0]);
            //Console.WriteLine();

            Console.WriteLine("List<string> para IEnumerable<object>");

            IEnumerable<object> enumObj = listaMeses; //COVARIÂNCIA

            foreach (var item in enumObj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
