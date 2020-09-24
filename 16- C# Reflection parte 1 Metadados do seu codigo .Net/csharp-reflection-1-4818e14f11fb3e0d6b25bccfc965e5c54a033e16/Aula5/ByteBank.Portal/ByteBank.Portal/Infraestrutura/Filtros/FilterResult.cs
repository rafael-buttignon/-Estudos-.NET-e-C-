namespace ByteBank.Portal.Infraestrutura.Filtros
{
    public class FilterResult
    {
        public FilterResult(bool podeContinuar)
        {
            PodeContinuar = podeContinuar;
        }

        public bool PodeContinuar { get; private set; }

        
    }
}
