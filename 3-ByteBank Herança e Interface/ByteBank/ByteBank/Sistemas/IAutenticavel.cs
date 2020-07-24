using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
    public interface Autenticavel
    {
        bool Autenticar(string senha);
    }
}
