﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var navegador = new Navegador();
            navegador.NavegarPara("google.com");
            navegador.NavegarPara("caelum.com");
            navegador.NavegarPara("alura.com.br");

            Console.WriteLine("X=X=X=X=X=X=X=X=X=X=X=X=X");

            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();

            Console.WriteLine("X=X=X=X=X=X=X=X=X=X=X=X=X");
            navegador.Proximo();
        }
    }

    internal class Navegador
    {
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();
        private string atual = "vazia";
        public Navegador()
        {
            Console.WriteLine("Página atual: " + atual);
        }

        internal void Anterior()
        {
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(atual);
                atual = historicoAnterior.Pop();
                Console.WriteLine("Página atual: " + atual);
            }

        }

        internal void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine("Página atual: " + atual);
        }

        internal void Proximo()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine("Página atual: " + atual);
            }
        }
    }
}
