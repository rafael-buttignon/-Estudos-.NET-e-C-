using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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

                if (path == "/Assets/css/style.css")
                {
                    //Retornar o nosso documento styles.css
                    var assembly = Assembly.GetExecutingAssembly();
                    var nomeResorce = "ByteBank.Portal.Assets.css.styles.css";
                    var resorceStream = assembly.GetManifestResourceStream(nomeResorce);
                    var bytesResource = new byte[resorceStream.Length];

                    resorceStream.Read(bytesResource, 0, (int)resorceStream.Length);

                    resposta.ContentType = "text/css; charset=utf-8";
                    resposta.StatusCode = 200;
                    resposta.ContentLength64 = resorceStream.Length;

                    resposta.OutputStream.Write(bytesResource, 0, bytesResource.Length);
                    resposta.OutputStream.Close();

                }
                else if (path == "/Assets/js/main.js")
                {
                    var assembly = Assembly.GetExecutingAssembly();
                    var nomeResorce = "Bytebank.Portal.Assets.js.main.js";
                    var resorceStream = assembly.GetManifestResourceStream(nomeResorce);
                    var bytesResource = new byte[resorceStream.Length];

                    resorceStream.Read(bytesResource, 0, (int)resorceStream.Length);

                    resposta.ContentType = "application/js; charset=utf-8";
                    resposta.StatusCode = 200;
                    resposta.ContentLength64 = resorceStream.Length;

                    resposta.OutputStream.Write(bytesResource, 0, bytesResource.Length);
                    resposta.OutputStream.Close();
                }
                httpListener.Stop();
            }
        }
    }
}
