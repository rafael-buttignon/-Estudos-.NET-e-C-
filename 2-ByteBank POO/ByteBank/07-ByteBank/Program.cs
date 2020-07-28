﻿using System;
using System.Runtime.CompilerServices;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                ContaCorrente conta = new ContaCorrente(0, 423434);
                Metodo();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Não e possivel dividir para 0.");
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentException ex)
            {
                //if(ex.ParamName == "numero")
                //{

                //}

                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
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
