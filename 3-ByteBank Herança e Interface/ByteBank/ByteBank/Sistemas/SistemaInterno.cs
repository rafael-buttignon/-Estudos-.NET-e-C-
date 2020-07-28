using System;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-Vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta");
                return false;
            }
        }
    }
}
