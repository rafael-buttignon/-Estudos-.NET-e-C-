using System;
using System.Net;

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
                    var manipulador = new ManipuladorRequisicaoArquivo();
                    manipulador.Manipular(resposta, path);
                }
                else if (path == "/Cambio/MXN")
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