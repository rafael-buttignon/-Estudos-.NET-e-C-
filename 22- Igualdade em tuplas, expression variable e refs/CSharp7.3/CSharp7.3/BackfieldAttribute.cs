using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7._3
{
    [Serializable]
    public class FormularioCadastro
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        private string _senha;
        [field: NonSerialized]
        public string Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = value;
            }
        }
    }

    public class BackfieldAttribute
    {
        public static void Testa()
        {
            var novoCadastro = new FormularioCadastro
            {
                Nome = "Gui",
                Email = "Gui@Alura.com.br",
                Senha = "senha super dificil e complicada de lembrar"
            };

            using (var arquivo = File.Create("cadastro.bin"))
            {
                var formatador = new BinaryFormatter();
                formatador.Serialize(arquivo, novoCadastro);
            }
        }
    }
}
