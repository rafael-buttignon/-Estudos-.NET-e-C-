using System.Reflection.Metadata.Ecma335;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario;
        }
    }
}
