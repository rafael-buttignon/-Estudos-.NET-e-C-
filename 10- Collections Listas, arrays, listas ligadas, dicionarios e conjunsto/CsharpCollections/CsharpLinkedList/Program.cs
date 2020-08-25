using System;
using System.Collections.Generic;

namespace CsharpLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new List<string>()
            {
                "abacate", "banana", "caqui", "damasco", "figo"
            };

            foreach(var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            LinkedList<string> dias = new LinkedList<string>();
            var d4 = dias.AddFirst("Quarta");
            //Console.WriteLine("d4 value: " + d4.Value);
            var d2 = dias.AddBefore(d4, "Segunda");
            var d3 = dias.AddAfter(d2, "Terça");
            var d6 = dias.AddAfter(d4, "Sexta");
            var d7 = dias.AddAfter(d6, "Sabado");
            var d5 = dias.AddBefore(d6, "Quinta");
            var d1 = dias.AddBefore(d2, "Domingo");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }
            Console.WriteLine("---------------------------");
            //LinkedList Não dá suporte ao acesso de indice: dias [0]
            //por isso podemos fazer um laço foreach mas não um for!

            //Cada elemento de um LinkedList é um nó, ou seja, um objeto LinkedListNode, 
            //que mantém duas referências, apontando para o nó anterior e outra apontando 
            //para o próximo nó, e essa lista pode ser navegada pela ordem definida pela associação entre esses nós.

            var quarta = dias.Find("Quarta");

            dias.Remove("Quarta");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }
        }
    }
}
