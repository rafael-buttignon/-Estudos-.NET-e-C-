using ByteBank.Portal.Controller;
using System;
using System.Net;
using System.Reflection;
using System.Text;

namespace ByteBank.Portal.Infraestrutura
{
    public class WebApplication
    {
        //http://bytebank.com/?
        //http://localhost:80/

        private readonly string[] _prefixos;

        public WebApplication(string[] prefixos)
        {
            if (prefixos == null)
                throw new ArgumentNullException(nameof(prefixos));
            _prefixos = prefixos;
        }

        public void Iniciar()
        {
            while (true)
            {
                ManipularRequisicao();
            }
        }

        private void ManipularRequisicao()
        {
            var httpListener = new HttpListener();

            foreach (var prefixo in _prefixos)
            {
                httpListener.Prefixes.Add(prefixo);
                httpListener.Start();

                var contexto = httpListener.GetContext();
                var requisicao = contexto.Request;
                var resposta = contexto.Response;

                var path = requisicao.Url.AbsolutePath;


                if (Utilidades.EhArquivo(path))
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
                        var bytesResource = new byte[resorceStream.Length];
                        resorceStream.Read(bytesResource, 0, (int)resorceStream.Length);
                        resposta.ContentType = Utilidades.ObterTipoDeConteudo(path);
                        resposta.StatusCode = 200;
                        resposta.ContentLength64 = resorceStream.Length;
                        resposta.OutputStream.Write(bytesResource, 0, bytesResource.Length);
                        resposta.OutputStream.Close();
                    }
                }
                else if(path == "/Cambio/MXN")
                {
                    //var controller = new CambioController();
                    //var paginaConteudo = controller.MXN();

                    //var bufferArquivo = Encoding.UTF8.GetBytes(paginaConteudo);

                    //resposta.StatusCode = 200;
                    //resposta.ContentType = Utilidades.ObterTipoDeConteudo(path);
                    //resposta.ContentType = "text/html; charset=utf-8";
                    //resposta.OutputStream.Write(bufferArquivo, 0, bufferArquivo.Length);
                    //resposta.OutputStream.Close();

                }
                httpListener.Stop();
            }
        }
    }
}