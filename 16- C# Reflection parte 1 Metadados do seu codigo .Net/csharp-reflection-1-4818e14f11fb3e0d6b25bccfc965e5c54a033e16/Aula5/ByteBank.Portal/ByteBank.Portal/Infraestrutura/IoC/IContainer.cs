﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Infraestrutura.IoC
{
    public interface IContainer
    {
        void Registrar(Type tipoOrigem, Type tipoDestino);
        void Registrar<TOrigem, TDestino>() where TDestino : TOrigem;

        object Recuperar(Type tipoOrigem);
    }
}
