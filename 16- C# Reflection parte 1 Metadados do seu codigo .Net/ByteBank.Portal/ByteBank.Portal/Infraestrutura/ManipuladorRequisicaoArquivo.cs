using System.Net;
using System.Reflection;

namespace ByteBank.Portal.Infraestrutura
{
    public class ManipuladorRequisicaoArquivo
    {
        public void Manipular(HttpListenerResponse resposta, string path)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var nomeResource = Utilidades.ConverterPathParaNomeAssembly(path);

            var nomeResorce = "Bytebank.Portal.Assets.js.main.js";
            var resorceStream = assembly.GetManifestResourceStream(nomeResorce);

            if (resorceStream == null)
            {
                resposta.StatusCode = 404;
                resposta.OutputStream.Close();
            }
            else
            {
                using (resorceStream)
                {
                    var bytesResource = new byte[resorceStream.Length];
                    resorceStream.Read(bytesResource, 0, (int)resorceStream.Length);
                    resposta.ContentType = Utilidades.ObterTipoDeConteudo(path);
                    resposta.StatusCode = 200;
                    resposta.ContentLength64 = resorceStream.Length;
                    resposta.OutputStream.Write(bytesResource, 0, bytesResource.Length);
                    resposta.OutputStream.Close();
                }
            }
        }
    }
}