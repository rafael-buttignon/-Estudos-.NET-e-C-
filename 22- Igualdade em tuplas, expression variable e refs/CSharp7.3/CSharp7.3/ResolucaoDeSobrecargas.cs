using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7._3
{
    public class DeInstanciaOuEstatico
    {
        public void TestaSobreCarga()
        {
            this.EscreveMensagem(null);
            DeInstanciaOuEstatico.EscreveMensagem(null);

        }

        public void EscreveMensagem(StringBuilder stringBuilder)
        {
            Console.WriteLine(stringBuilder);
        }
        public static void EscreveMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }

    class MelhoriaEmSobreCargaDeMetodoGenerico
    {
        void TestaMelhoria()
        {
            EscreveMensagem("mensagem", 2);
        }

        public void EscreveMensagem<T>(T objeto, int numero) where T : IDisposable
        {
            Console.WriteLine(objeto);
        }

        public void EscreveMensagem<T>(T objeto, short numero)
        {
            Console.WriteLine(objeto);
        }
    }

    class MelhoriaEmSobreCargaDeDelegates
    {
        void Teste()
        {
            TestaDelegate(int.Parse);
            TestaDelegate(EscreveMensagem);
        }

        public void TestaDelegate(Func<string, int> func) =>
            Console.WriteLine("Func<string, int>");

        public void TestaDelegate(Action<string> action) =>
            Console.WriteLine("Action<string>");

        public void EscreveMensagem(string a) => 
            Console.WriteLine(a);
    }
}
