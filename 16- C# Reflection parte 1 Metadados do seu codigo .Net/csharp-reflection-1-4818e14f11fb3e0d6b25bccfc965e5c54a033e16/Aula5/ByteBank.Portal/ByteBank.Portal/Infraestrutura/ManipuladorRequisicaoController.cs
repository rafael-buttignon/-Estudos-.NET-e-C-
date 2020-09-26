using ByteBank.Portal.Infraestrutura.Binding;
using ByteBank.Portal.Infraestrutura.Filtros;
using System;
using System.Net;
using System.Text;
using IContainer = ByteBank.Portal.Infraestrutura.IoC.IContainer;

namespace ByteBank.Portal.Infraestrutura
{
    public class ManipuladorRequisicaoController
    {
        private readonly ActionBinder _actionBinder = new ActionBinder();
        private readonly FilterResolver _filterResolver = new FilterResolver();
        private readonly ControllerResolver _controllerResolver;
        public ManipuladorRequisicaoController(IContainer container)
        {
            _controllerResolver = new ControllerResolver(container);
        }

        public void Manipular(HttpListenerResponse resposta, string path)
        {
            var partes = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            var controllerNome = partes[0];
            var actionNome = partes[1];

            var controllerNomeCompleto = $"ByteBank.Portal.Controller.{controllerNome}Controller";

            //var controllerWrapper = Activator.CreateInstance("ByteBank.Portal", controllerNomeCompleto, new object[0]);
            //var controller = controllerWrapper.Unwrap();

            var controller = _controllerResolver.ObterController(controllerNomeCompleto);
            //var methodInfo = controller.GetType().GetMethod(actionNome);
            var actionBindInfo = _actionBinder.ObterActionBindInfo(controller, path);

            var filterResult = _filterResolver.VerficarFiltros(actionBindInfo);

            if (filterResult.PodeContinuar)
            {
                var resultadoAction = (string)actionBindInfo.Invoke(controller);

                var buffer = Encoding.UTF8.GetBytes(resultadoAction);

                resposta.StatusCode = 200;
                resposta.ContentType = "text/html; charset=utf-8";
                resposta.ContentLength64 = buffer.Length;

                resposta.OutputStream.Write(buffer, 0, buffer.Length);
                resposta.OutputStream.Close();
            }
            else
            {
                resposta.StatusCode = 307;
                resposta.RedirectLocation = "/Erro/Inesperado";
                resposta.OutputStream.Close();
            }
        }
    }
}
