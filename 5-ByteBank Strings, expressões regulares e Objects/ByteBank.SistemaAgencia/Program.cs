﻿using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using System;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {


            //string padrao ="[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";



            string textoDeTexte = "Meu nome e Rafael, me ligue em 4784-4546";

            Match resultado = Regex.Match(textoDeTexte, padrao);

            Console.WriteLine(resultado.Value);

            Console.ReadLine();















            string urlteste = "http://www.bytebank.com/cambio";
            int indiceByteBank = urlteste.IndexOf("http://www.bytebank.com");


            Console.WriteLine(urlteste.StartsWith("http://www.bytebank.com"));
            Console.WriteLine(urlteste.EndsWith("cambio"));
            Console.WriteLine(urlteste.Contains("Bytebank"));
            Console.ReadLine();


            string textoVazio = "";
            string textoNullo = null;
            string textoTop = "Qualqueeer";
            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNullo));
            Console.WriteLine(String.IsNullOrEmpty(textoTop));
            Console.WriteLine();

            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagemOrigem.ToLower());

            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();


            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            Console.WriteLine(extratorDeValores.GetValor("valor"));

            Console.ReadLine();




            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length + 1));


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');
            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);


            //string texto = "Gustavo Silva";
            //texto.Substring(8);
            //string texto2 = texto.Substring(1);
            //Console.WriteLine("Sobrenome: " + texto);
            //Console.WriteLine(texto2);

            Console.ReadLine();
        }

    }
}
