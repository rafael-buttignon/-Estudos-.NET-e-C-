using System;
using System.IO;

namespace _07_ByteBank
{
    public class LeitorDeArquivos : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivos(string arquivo)
        {
            Arquivo = arquivo;
            ////throw new FileNotFoundException();

            Console.WriteLine("Abrindo Arquivo: " + arquivo);
        }
        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha ....");

            throw new IOException();

            return "Linha do arquivo";
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");

        }
    }
}
