using System;
using System.Linq;

namespace ByteBank.Portal.Infraestrutura
{
    public class Utilidades
    {

        public static bool EhArquivo(string path)
        {
            var partesPath = path.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
            var ultimaParte = partesPath.Last();

            return ultimaParte.Contains('.');
        }

        public static string ConverterPathParaNomeAssembly(string path)
        {
            // Assets/css/styles.css
            // /Assets/js/main.js

            var prefixoAssembly = "ByteBank.Portal";
            var pathComPontos = path.Replace('/', '.');

            var nomeCompleto = $"{prefixoAssembly}{pathComPontos}";

            return nomeCompleto;
        }

        public static string ObterTipoDeConteudo(string path)
        {
            if (path.EndsWith(".css"))
                return "text/css; charset=utf-8";
            if (path.EndsWith(".html"))
                return "application/js; charset=utf-8";
            if (path.EndsWith(".html"))
                return "application/html; charset=utf-8";

            throw new NotImplementedException("Tipo de conteudo não previsto!");
        }
    }
}