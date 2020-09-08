using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Validation;
using System;
using System.Diagnostics;

namespace CsharpBrasil.Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf1 = "86288366757";
            string cpf2 = "98745366797";
            string cpf3 = "22222222222";

            string cnpj1 = "36833355000109";
            string cnpj2 = "24245311000189";

            string titulo1 = "378394962471";
            string titulo2 = "574295831066";



            ValidatorDeCpf(cpf1);
            ValidatorDeCpf(cpf2);
            ValidatorDeCpf(cpf3);

            ValidarCpfIsValid(cpf1);
            ValidarCpfIsValid(cpf2);
            ValidarCpfIsValid(cpf3);

            ValidarCNPJ(cnpj1);
            ValidarCNPJ(cnpj2);

            ValidarTitulo(titulo1);
            ValidarTitulo(titulo2);

            Debug.WriteLine(cpf1);

            var cpfFormater = new CPFFormatter().Format(cpf1);
            Console.WriteLine(cpfFormater);

            FormatarCpf(cpfFormater);
            Console.WriteLine(cpfFormater);

            var unFormatado = new CPFFormatter().Unformat(cpfFormater);
            Console.WriteLine(unFormatado);

            Console.WriteLine(cnpj1);

            var cnpjFormatado = new CNPJFormatter().Format(cnpj1);
            Console.WriteLine(cnpjFormatado);

            Console.WriteLine(titulo1);
            var tituloFormatado = new TituloEleitoralFormatter().Format(titulo1);
            Console.WriteLine(tituloFormatado);
        }

        private static void FormatarCpf(string cpfFormater)
        {
            new CPFFormatter().Format(cpfFormater);
        }

        private static void ValidarTitulo(string titulo)
        {
            if (new TituloEleitoralValidator().IsValid(titulo))
            {
                Debug.WriteLine("Título válido: " + titulo);
            }
            else
            {
                Debug.WriteLine("Título Inválido: " + titulo);
            }
        }

        private static void ValidarCNPJ(string cnpj)
        {
            if (new CNPJValidator().IsValid(cnpj))
            {
                Debug.WriteLine("CNPJ válido : " + cnpj);
            }
            else
            {
                Debug.WriteLine("CNPJ Inválido : " + cnpj);

            }
        }

        private static void ValidarCpfIsValid(string cpf)
        {
            if (new CPFValidator().IsValid(cpf))
            {
                Debug.WriteLine("CPF Válido: " + cpf);
            }
            else
            {
                Debug.WriteLine("CPF Inválido: " + cpf);
            }
        }

        private static void ValidatorDeCpf(string cpf)
        {
            try
            {
                new CPFValidator().AssertValid(cpf);
                Debug.WriteLine("CPF Válido: " + cpf);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("CPF Inválido: " + cpf, ex.ToString());
            }
        }
    }
}
