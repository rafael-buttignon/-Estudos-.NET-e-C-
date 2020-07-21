using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);
            bool resultadoSaque = contaDoBruno.Sacar(100);

            contaDoBruno.Sacar(99);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);
            Console.WriteLine();

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine();

            ContaCorrente contadaGabriela = new ContaCorrente();

            contadaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno ANTES: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela ANTES: " + contadaGabriela.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contadaGabriela);

            Console.WriteLine("Saldo do Bruno DEPOIS: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela DEPOIS: " + contadaGabriela.saldo);
            Console.WriteLine("Resultado da Transferencia: " + resultadoTransferencia );

            contadaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("Nova Transferencia da Gabriela: " + contadaGabriela.saldo);
            Console.WriteLine("Nova Transferencia do Bruno: " + contaDoBruno.saldo);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
