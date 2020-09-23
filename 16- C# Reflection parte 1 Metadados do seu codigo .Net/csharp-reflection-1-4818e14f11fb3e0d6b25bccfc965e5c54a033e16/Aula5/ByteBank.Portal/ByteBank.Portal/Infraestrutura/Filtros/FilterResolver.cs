using ByteBank.Portal.Filtros;
using ByteBank.Portal.Infraestrutura.Binding;

namespace ByteBank.Portal.Infraestrutura.Filtros
{
    public class FilterResolver
    {
        public object VerficarFiltros(ActionBindInfo actionBindInfo)
        {
            var methodInfo = actionBindInfo.MethodInfo;


            var atributos = methodInfo.GetCustomAttributes(typeof(FiltroAttribute), false);

            foreach (FiltroAttribute filtro in atributos)
            {
                filtro.PodeContinuar();
            }

            //methodInfo.GetCustomAttributes;
        }
    }
}
