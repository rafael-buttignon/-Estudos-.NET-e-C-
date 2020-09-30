using ByteBank.Agencias.DAL;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ByteBank.Agencias
{
    /// <summary>
    /// Interaction logic for EdicaoAgencia.xaml
    /// </summary>
    public partial class EdicaoAgencia : Window
    {
        private readonly Agencia _agencia;

        public EdicaoAgencia(Agencia agencia)
        {
            InitializeComponent();

            _agencia = agencia ?? throw new ArgumentNullException(nameof(agencia));
            AtualizarCamposDeTexto();
            AtualizarControles();
        }

        private void AtualizarCamposDeTexto()
        {
            txtNumero.Text = _agencia.Numero;
            txtNome.Text = _agencia.Nome;
            txtTelefone.Text = _agencia.Telefone;
            txtEndereco.Text = _agencia.Endereco;
            txtDescricao.Text = _agencia.Descricao;
        }

        private void AtualizarControles()
        {
            RoutedEventHandler dialogResultTrue = (o, e) => DialogResult = true;
            RoutedEventHandler dialogResultFalse = (o, e) => DialogResult = false;

            var okEventHandler = dialogResultTrue + Fechar;
            var cancelarEventHandler = dialogResultFalse + Fechar;

            btnOk.Click += okEventHandler;
            btnCancelar.Click += cancelarEventHandler;

            txtNome.TextChanged += ValidarCampoNulo;
            txtNome.TextChanged += ValidarCampoNulo;
            txtNome.TextChanged += ValidarCampoNulo;
            txtNome.TextChanged += ValidarCampoNulo;
            txtNome.TextChanged += ValidarCampoNulo;
        }

        private void ValidarCampoNulo(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
                var textoEstaVazio = String.IsNullOrEmpty(txt.Text);
                txt.Background = textoEstaVazio ?
                new SolidColorBrush(Colors.OrangeRed) :
                new SolidColorBrush(Colors.White);
        }

        private void Fechar(object sender, EventArgs e) =>
            Close();
    }

    public class AgenciaPessoaFisica : Agencia
    {
    }

    public class AgenciaPessoaJuridica : Agencia
    {
    }

    public class ExtensoesAgencia
    {
        public void InaugurarAgencia(Agencia a)
        {
            InaugurarAgencia(new AgenciaPessoaFisica());
            InaugurarAgencia(new AgenciaPessoaJuridica());
        }
    }
}