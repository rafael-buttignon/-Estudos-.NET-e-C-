using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.Parte3.Aula6.R64.ReplaceDelegationWithInheritance.antes
{
    class Programa
    {
        void Teste()
        {
            var imovel = 
                new Apartamento("Rua dos Bobos, No. 0", 100000, 200);
        }
    }

    abstract class Imovel
    {
        private readonly String endereco;
        private decimal valorImovel;

        public string Endereco => endereco;
        public decimal ValorImovel { get => valorImovel; set => valorImovel = value; }

        public Imovel(string endereco, decimal valorImovel)
        {
            this.endereco = endereco;
            this.valorImovel = valorImovel;
        }
    }

    class Apartamento : Imovel
    {
        private decimal valorCondominio;

        public Apartamento(string endereco, decimal valorImovel, decimal valorCondominio)
            : base(endereco, valorImovel)
        {
            this.valorCondominio = valorCondominio;
        }
    }
}
