using System;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    class Program 
    { 
        static void Main(string[] args) 
        {
            var enderecoDoArquivo = "contas.txt";

            var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

            var buffer = new byte[1024]; // 1 Kb

            var numeroDeBytesLidos = -1;

            while(numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            foreach (var meuByte in buffer)
            {
                Console.Write(meuByte);
                Console.Write(" ");
            }
        }
    }
} 
 