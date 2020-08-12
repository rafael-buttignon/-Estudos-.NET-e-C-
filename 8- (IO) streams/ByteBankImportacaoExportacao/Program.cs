using System;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program 
    { 
        static void Main(string[] args) 
        {
            var enderecoDoArquivo = "contas.txt";

            using(var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
                using (var leitor = new StreamReader(fluxoDeArquivo)) 
                {
                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadToEnd();
                        Console.WriteLine(linha);
                    }
                } 
            Console.ReadLine();
        }
    }
} 
 