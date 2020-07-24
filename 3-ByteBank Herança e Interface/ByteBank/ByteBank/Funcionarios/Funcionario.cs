namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }

        public double GetBonificacao()
        {
            if(_tipo == 1)
            {
                return Salario;
            }

            return Salario * 0.10;
        }
    }
}
