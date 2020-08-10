using System.Collections.Generic;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            // this é metodo de extensão

            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        static void Teste()
        {
            List<int> idades = new List<int>();

            idades.Add(15);
            idades.Add(40);
            idades.Add(55);

            idades.AdicionarVarios(15, 22, 55, 67);
        }
    }
}
