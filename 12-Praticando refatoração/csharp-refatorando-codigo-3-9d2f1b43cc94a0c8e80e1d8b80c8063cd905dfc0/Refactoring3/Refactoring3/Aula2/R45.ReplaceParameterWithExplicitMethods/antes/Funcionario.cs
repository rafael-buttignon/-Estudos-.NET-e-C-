using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.Parte3.Aula2.R45.ReplaceParameterWithExplicitMethods.antes
{
    class Program
    {
        void Main()
        {
            var funcionario1 = new Funcionario("Tony Estarque", 10000);
            var funcionario2 = new Funcionario("Pedro Parques", 2000);

            funcionario1.DarAumentoFixo(3000);
            funcionario2.DarAumentoPorcentual(10);
        }
    }

    class Funcionario
    {
        readonly string nome;
        public string Nome => nome;

        decimal salario;
        public decimal Salario => salario;

        public Funcionario(string nome, decimal salario)
        {
            this.nome = nome;
            this.salario = salario;
        }
        public void DarAumentoFixo(decimal aumento)
        {
            salario += aumento;
        }
        public void DarAumentoPorcentual(decimal aumento)
        {
            salario *= (1.0m + aumento / 100.0m);
        }
    }
}
