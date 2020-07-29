using System;

namespace _07_ByteBank
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {

        }

        public OperacaoFinanceiraException(string message)
            : base(message)
        {

        }
        
        public OperacaoFinanceiraException(string message, Exception exceptionInterna)
            : base(message, exceptionInterna)
        {

        }
    }
}
