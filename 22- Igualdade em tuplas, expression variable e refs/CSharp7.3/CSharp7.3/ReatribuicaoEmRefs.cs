using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7._3
{
    public class ReatribuicaoEmRefs
    {
        public static void TestaRefs()
        {
            var numeros = new[] { 1, 3, 7, 15, 31, 1023, 63, 127, 255, 511 };
            EscreverNumeros(numeros);

            ref var maiorValor = ref ObterMaiorValor(numeros);
            Console.WriteLine($"Maior valor: {maiorValor}");

            maiorValor = maiorValor * 2;
            Console.WriteLine($"Maior valor * 2: {maiorValor}");

            EscreverNumeros(numeros);
        }

        private static ref int ObterMaiorValor(int[] numeros)
        {
            Span<int> numerosSpan = new Span<int>(numeros);

            ref var maior = ref numeros[0];

            foreach (ref var item in numerosSpan.Slice(0))
            {
                if (item > maior)
                {
                    maior = ref item;
                }
            }

            return ref maior;
        }
        private static void EscreverNumeros(int[] numeros) =>
            Console.WriteLine(string.Join(", ", numeros));

        class MeuIteravel
        {
            public MeuEnumerator GetEnumerador()
            {
                return new MeuEnumerator();
            }
        }

        class MeuEnumerator
        {
            private int[] numeros = { 1, 2, 3 };
            public ref int Current
            {
                get
                {
                    return ref numeros[0];
                }
            }
        }

        public bool MoveNext()
        {
            return false;
        }
    }
}
