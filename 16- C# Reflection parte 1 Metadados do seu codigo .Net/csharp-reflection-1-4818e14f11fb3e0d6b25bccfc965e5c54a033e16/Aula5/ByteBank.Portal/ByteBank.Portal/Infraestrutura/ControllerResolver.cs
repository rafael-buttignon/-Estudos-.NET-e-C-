using ByteBank.Portal.Infraestrutura.IoC;
using System;

namespace ByteBank.Portal.Infraestrutura
{
    public class ControllerResolver : ControllerBase
    {
        private readonly IContainer _container;

        public ControllerResolver(IContainer container)
        {
            _container = container;
        }

        public object ObterController(string nomeController)
        {
            var tipoController = Type.GetType(nomeController);
            var instanciaController = _container.Recuperar(tipoController);
            return instanciaController;
        }
    }
}
