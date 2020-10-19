using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7._3
{
    static class TesteTuples
    {
        public static void TestaTuple()
        {
            // Rua, Numero, Cidade
            var origem = ("Avenida Paulista", "900", "São Paulo");
            var destino = ("Avenida Paulista", "300", "São Paulo");


            //var mesmoLugar = 
            //    origem.Item1 == destino.Item1 && 
            //    origem.Item2 == destino.Item2 && 
            //    origem.Item3 == destino.Item3;


            var mesmoLugar = origem == destino;

            Console.WriteLine(mesmoLugar);
        }
    }
}
