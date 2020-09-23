using System;

namespace ByteBank.Portal.Infraestrutura.Filtros
{
    public abstract class FiltroAttribute : Attribute
    {
        public abstract bool PodeContinuar();
    }
}
