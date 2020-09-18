using ByteBank.Service;
using ByteBank.Service.Cambio;
using System.IO;
using System.Reflection;

namespace ByteBank.Portal.Controller
{
    public class CambioController
    {
        public ICambioService _cambioService;

        public CambioController(ICambioService cambioService)
        {
            _cambioService = new CambioTesteService();
        }

        public string MXN()
        {
            var valorFinal = _cambioService.Calcular("MXN", "BRL", 1);
            var nomeCompletoResource = "ByteBank.Portal.View.Cambio.MXN.html";
            var assembly = Assembly.GetExecutingAssembly();
            var streamResorce = assembly.GetManifestResourceStream(nomeCompletoResource);

            var streamLeitura = new StreamReader(streamResorce);
            var textoPagina = streamLeitura.ReadToEnd();

            var textoResultado = textoPagina.Replace("VALOR_EM_REAIS", valorFinal.ToString());

            return textoResultado;
        }

        public string USD()
        {
            return null;
        }
    }
}