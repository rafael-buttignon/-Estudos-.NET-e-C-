using System;
using System.Linq;

namespace CSharp7._3
{
    class AplicacaoWeb
    {
        public static string Porta = "8080";

        public static bool EstaRodandoEmPortaAlta =
            int.TryParse(Porta, out int portaComoint) && portaComoint > 1024;
    }


    public class ExpressionVariables
    {

        public bool ValidadeIdade(string idadeComoTexto) =>
            int.TryParse(idadeComoTexto, out int idade) && idade > 18;


        public static void TestaExpressionVariables()
        {
            var idadeComoTexto = "15";


            if(int.TryParse(idadeComoTexto, out int idade) && idade > 18)
            {
                Console.WriteLine("Você pode entrar");
            }

        }

        public static void RegistroDeAlunos()
        {
            var registroAlunos = new string[]
            {
                "1110651", "1020651", "1110600",
                "1310800", "211060T", "011060W"
            };

            var alunosValidos =
                from ra in registroAlunos
                where int.TryParse(ra, out int raComoInt) && raComoInt > 1000
                select ra + " é válido";
        }
    }
}
