using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor(5000, "159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta(4000, "234.632.622-01");
            camila.Nome = "Camila";
            camila.Senha = "123";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "123");


        }

        public static void CalcularBonificacao()
        {
            GerenciadorBoneficacao gerenciadorBoneficacao = new GerenciadorBoneficacao();

            Designer pedro = new Designer(3000, "833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor(5000, "159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar(2000, "445.112.664-11");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta(4000, "234.632.622-01");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor(4000, "234.632.622-01");
            guilherme.Nome = "Guilherme";

            gerenciadorBoneficacao.Registrar(pedro);
            gerenciadorBoneficacao.Registrar(roberta);
            gerenciadorBoneficacao.Registrar(igor);
            gerenciadorBoneficacao.Registrar(camila);
            gerenciadorBoneficacao.Registrar(guilherme);


            Console.WriteLine("Total de bonificações do mês " + gerenciadorBoneficacao.GetTotalBonificacao());
        }
    }
}
