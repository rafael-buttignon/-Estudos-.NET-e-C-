using System;
using System.Dynamic;

namespace _1_FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo. Review para certificação C# [Alura] ");

            int idade = 37;
            Console.WriteLine("a idade é " + idade + ", parabéns!");

            double salario = 1200.50;

            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            char letra = 'a';
            Console.WriteLine(letra);

            string palavra = "alura cursos online de tecnologia";
            Console.WriteLine(palavra);

            palavra = palavra + 2020;
            Console.WriteLine(palavra);
            Console.WriteLine();

            double valorInvestido = 1000;
            int contadorMes = 1;

            while(contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " messes, você tera R$ " + valorInvestido);

                contadorMes++;
            }

            Console.WriteLine();
            double valorInvestido1 = 1000;

            for (contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido1 *= 1.0036;
                Console.WriteLine(
                    "Após " + contadorMes +
                    "messes, você tera R$ " + valorInvestido1);
            }

            Console.WriteLine();

            double fatorRendimento = 1.0036;
            double valorInvestido2 = 1000;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for(int contadorMes1 = 1; contadorMes1 <= 12; contadorMes1++)
                {
                    valorInvestido2 *= fatorRendimento;
                }
                fatorRendimento += 0.0010; 
            }
            Console.WriteLine();

            for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for(int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for (int contador = 0; contador <= 10; contador++)
                {
                    Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Tempo de investimento foi de " + contadorMes);
            Console.WriteLine("Ao término do investimento, você terá R$ " + valorInvestido2);

            Console.WriteLine();
            Console.WriteLine("A execução acabou. Tecle enter para finalizar . . . ");
            Console.ReadLine();


        }
    }
}
