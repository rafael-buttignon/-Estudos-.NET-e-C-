using ByteBank.Sistemas;
using System.Reflection.Metadata.Ecma335;

namespace ByteBank.Funcionarios
{
    public class Diretor : Autenticavel
    {
        public Diretor(double salario, string cpf) : base(salario, cpf)
        {

        }
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }
    }
}
