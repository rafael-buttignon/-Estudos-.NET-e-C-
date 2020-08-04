using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "pagina?argumentos";

            //Console.WriteLine(url);
            //string argumentos = url.Substring(7);
            //Console.WriteLine(argumentos);


            string texto = "Gustavo Silva";

            texto.Substring(8);
            string texto2 = texto.Substring(1);

            Console.WriteLine("Sobrenome: " + texto);
            Console.WriteLine(texto2);

            Console.ReadLine();
        }

    }
}
