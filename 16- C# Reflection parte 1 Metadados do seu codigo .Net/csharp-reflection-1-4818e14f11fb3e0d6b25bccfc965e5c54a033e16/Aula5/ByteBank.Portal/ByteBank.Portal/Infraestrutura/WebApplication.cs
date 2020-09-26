using ByteBank.Portal.Infraestrutura.IoC;
using ByteBank.Service;
using ByteBank.Service.Cambio;
using ByteBank.Service.Cartao;
using System;
using System.Net;

namespace ByteBank.Portal.Infraestrutura
{
    public class WebApplication
    {
        public class CartaoServiceTesteContaine : ICartaoService
        {
            string ICartaoService.ObterCartaoDeCreditoDeDestaque() => "Cartão de Crédito do Teste de Container";
            string ICartaoService.ObterCartaoDeDebitoDeDestaque() => "Cartão de Débito do Teste de Container";

        }

        private readonly string[] _prefixos;
        private readonly IContainer _container = new ContainerSimples();

        public WebApplication(string[] prefixos)
        {
            if (prefixos == null)
                throw new ArgumentNullException(nameof(prefixos));
            _prefixos = prefixos;

            Configurar();
        }

        private void Configurar()
        {
            _container.Registrar<ICartaoService, CartaoServiceTeste>();
            _container.Registrar<ICambioService, CambioTesteService>();
        }

        public void Iniciar()
        {
            while (true)
                ManipularRequisicao();
        }

        private void ManipularRequisicao()
        {
            var httpListener = new HttpListener();

            foreach (var prefixo in _prefixos)
                httpListener.Prefixes.Add(prefixo);

            httpListener.Start();

            var contexto = httpListener.GetContext();
            var requisicao = contexto.Request;
            var resposta = contexto.Response;

            var path = requisicao.Url.PathAndQuery;

            if(Utilidades.EhArquivo(path))
            {
                var manipulador = new ManipuladorRequisicaoArquivo();
                manipulador.Manipular(resposta, path);
            }
            else
            {
                var manipulador = new ManipuladorRequisicaoController(_container);
                manipulador.Manipular(resposta, path);
            }

            httpListener.Stop();
        }
    }
}
