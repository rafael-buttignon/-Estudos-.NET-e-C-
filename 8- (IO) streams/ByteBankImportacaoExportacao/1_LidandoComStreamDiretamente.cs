using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void LidadnoComFileStreamDiretamente()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024]; // 1 Kb
                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }
            }
        }

        static void EscreverBuffer(byte[] buffer, int byteslidos)
        {
            var utf8 = Encoding.Default;

            var texto = utf8.GetString(buffer, 0, byteslidos);
            Console.Write(texto);

            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }
    }

}