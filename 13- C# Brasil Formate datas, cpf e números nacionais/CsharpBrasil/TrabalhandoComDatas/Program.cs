using System;
using System.Diagnostics;
using System.Globalization;

namespace TrabalhandoComDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2017, 9, 23);

            Debug.WriteLine(data);
            Console.WriteLine(data.ToString("d"));
            Console.WriteLine(data.ToString("d", new CultureInfo("pt-BR")));
            Console.WriteLine(data.ToString("dd/MM"));
            Console.WriteLine(data.ToString("dd/MM/yy"));

            data = new DateTime(2017, 9, 23, 13, 14, 15, 987);

            Console.WriteLine(data);
            Console.WriteLine(data.ToString("HH:mm"));
            Console.WriteLine(data.ToString("HH:mm:ss.fff"));

            Console.WriteLine(data.ToString("D"));
            Console.WriteLine(data.ToString("m"));
            Console.WriteLine(data.ToString("Y"));

            Console.WriteLine(data.ToString("G"));
            Console.WriteLine(data.ToString("g"));

            Console.WriteLine(data.ToString("O"));
            Console.WriteLine(DateTime.Parse(data.ToString("O")).ToString("dd/MM/yyyy HH:mm:ss.fff"));


            Console.WriteLine(data.ToString("t"));
            Console.WriteLine(data.ToString("T"));




        }

    }
}
