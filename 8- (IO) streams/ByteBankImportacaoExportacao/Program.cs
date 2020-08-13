using ByteBankImportacaoExportacao.Modelos;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program 
    { 
        static void Main(string[] args) 
        {

            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

            Console.WriteLine("Arquivo escrevendoComAClasseFile criado!");

            Console.ReadLine();


            var bytesArquivo = File.ReadAllBytes("contas.txt");
            
            Console.WriteLine($"Arquivo contas.txt pussui {bytesArquivo.Length} ");


           var linhas = File.ReadAllLines("contas.txt", Encoding.UTF8);
            Console.WriteLine(linhas.Length);

            foreach (var item in linhas)
            {
                Console.WriteLine(item);
            }

            var nome = Console.ReadLine();


            Console.WriteLine("Digite o seu nome: ");
            var nomex = Console.ReadLine();

            Console.WriteLine(nomex);


            UsarStreamDeEntrada();

            Console.WriteLine("Aplicação Finalizada...");
            Console.ReadLine();
        }
    }
} 
 