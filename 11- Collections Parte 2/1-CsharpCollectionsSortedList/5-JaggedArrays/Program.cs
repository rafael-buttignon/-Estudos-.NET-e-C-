using System;

namespace _5_JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //JAGGED ARRAY = ARRAY DENTEADO = OU ARRAY SERRILHADO
            //Um array denteado ou matriz denteada(jagged array) é uma matriz cujos elementos são matrizes.

            string[][] familias = new string[3][];
            //{
            //    { "Fred", "Wilma", "Pedrita"},
            //    {"Homer", "Marge", "Lisa", "Bart", "Maggie" },
            //    {"Florinda", "Kiko" }
            //};
             
            familias[0] = new string[] { "Fred", "Wilma", "Pedrita" };
            familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
            familias[2] = new string[] { "Florinda", "Kiko" };


            foreach (var familia in familias)
            {
                
                Console.WriteLine($"Familia: " + string.Join(", ", familia));
            }
        }
    }
}
