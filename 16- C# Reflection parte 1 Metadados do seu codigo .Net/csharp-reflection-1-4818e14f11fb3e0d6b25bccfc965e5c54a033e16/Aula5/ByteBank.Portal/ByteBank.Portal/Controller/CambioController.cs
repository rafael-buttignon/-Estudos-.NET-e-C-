﻿using ByteBank.Portal.Filtros;
using ByteBank.Portal.Infraestrutura;
using ByteBank.Service;

namespace ByteBank.Portal.Controller
{
    public class CambioController : ControllerBase
    {
        private ICambioService _cambioService;
        private ICartaoService _cartaoService;

        public CambioController(ICambioService cambioService, ICartaoService cartaoService)
        {
            _cambioService = cambioService;
            _cartaoService = cartaoService;
        }

        [ApenasHorarioComercialFiltroAttribute]
        public string MXN()
        {
            var valorFinal = _cambioService.Calcular("MXN", "BRL", 1);
            var textoPagina = View();

            var textoResultado = textoPagina.Replace("VALOR_EM_REAIS", valorFinal.ToString());

            return textoResultado;
        }

        [ApenasHorarioComercialFiltroAttribute]
        public string USD()
        {
            var valorFinal = _cambioService.Calcular("USD", "BRL", 1);
            var textoPagina = View();

            var textoResultado = textoPagina.Replace("VALOR_EM_REAIS", valorFinal.ToString());

            return textoResultado;
        }

        [ApenasHorarioComercialFiltroAttribute]
        public string Calculo(string moedaOrigem, string moedaDestino, decimal valor)
        {
            var valorFinal = _cambioService.Calcular(moedaOrigem, moedaDestino, valor);
            var cartaoPromocao = _cartaoService.ObterCartaoDeCreditoDeDestaque();
            var modelo = new
            {
                MoedaDestino = moedaDestino,
                ValorDestino = valorFinal,
                MoedaOrigem = moedaOrigem,
                ValorOrigem = valor,
                CartaoPromocao = cartaoPromocao
            };

            return View(modelo);
        }

        [ApenasHorarioComercialFiltroAttribute]
        public string Calculo(string moedaDestino, decimal valor) =>
            Calculo("BRL", moedaDestino, valor);

        [ApenasHorarioComercialFiltroAttribute]
        public string Calculo(string moedaDestino) =>
            Calculo("BRL", moedaDestino, 1);
    }
}