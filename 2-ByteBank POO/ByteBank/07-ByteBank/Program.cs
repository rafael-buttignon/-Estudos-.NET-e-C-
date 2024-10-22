﻿using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch
            {
                Console.WriteLine("CATCH NO METODO MAIN");
            }

            Console.WriteLine("Execução Finalizada!");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                leitor.LerProximaLinha();
            }


            // ----------------------------------

            //LeitorDeArquivos leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivos("contas.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch(IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            //}
            //finally
            //{
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}

        }

        private static void TestInnerExcepetion()
        {

            try
            {
                ContaCorrente conta = new ContaCorrente(45453, 423434);
                ContaCorrente conta2 = new ContaCorrente(4345, 434234);

                conta2.Transferir(200000, conta);

                conta.Depositar(50);
                Console.WriteLine(conta.GetSaldo());
                conta.Sacar(-500);
                Console.WriteLine(conta.GetSaldo());

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Não e possivel dividir para 0.");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "numero")
                {

                }
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna): ");
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero = " + numero+ " e divisor =" + divisor);
                throw;
            }
        }
    }
}
