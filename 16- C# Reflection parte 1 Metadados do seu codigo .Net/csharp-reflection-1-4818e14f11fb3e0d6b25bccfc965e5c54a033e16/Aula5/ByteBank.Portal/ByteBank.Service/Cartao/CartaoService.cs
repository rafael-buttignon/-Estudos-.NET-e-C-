namespace ByteBank.Service.Cartao
{
    public class CartaoServiceTeste : ICartaoService
    {
        public string ObterCartaoDeCreditoDeDestaque() =>
            "ByteBank Gold Platinum Extra Premium Special";

        public string ObterCartaoDeDebitoDeDestaque() =>
            "ByteBank EEstudante Sem Taxas de Manutenção";
    }
}
