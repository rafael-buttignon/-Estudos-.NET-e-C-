﻿using ByteBank.Portal.Infraestrutura;
using ByteBank.Service;

namespace ByteBank.Portal.Controller
{
    public class CartaoController : ControllerBase
    {
        private ICartaoService _cartaoService;

        public CartaoController(ICartaoService cartaoService)
        {
            _cartaoService = cartaoService;
        }

        public string Debito() => View(new { CartaoNome = _cartaoService.ObterCartaoDeDebitoDeDestaque() });

        public string Credito() => View(new { CartaoNome = _cartaoService.ObterCartaoDeCreditoDeDestaque() });
    }
}
