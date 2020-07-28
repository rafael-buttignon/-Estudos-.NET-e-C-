using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
