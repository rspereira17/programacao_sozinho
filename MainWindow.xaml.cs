using programacao_sozinho.Dao;
using programacao_sozinho.Model;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace programacao_sozinho
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InserirButton_Click(object sender, RoutedEventArgs e)
        {
            Clientes clientes = new Clientes();

            if (!ContemApenasNumeros(nifTXT.Text))
            {
                MessageBox.Show("O campo só pode ter números");
            }
            else
            {
                clientes.nif = int.Parse(nifTXT.Text);
                clientes.nome = nomeTXT.Text;
                clientes.profissao = profissaoTXT.Text;
                clientes.empresa = empresaTXT.Text;
                clientes.email = emailTXT.Text;
                clientes.telemovel = telemovelTXT.Text;
                clientes.endereco = enderecoTXT.Text;
                clientes.cidade = cidadeTXT.Text;
                clientes.pais = paisTXT.Text;

                ClienteDAO dao = new ClienteDAO();
                dao.inserirCliente(clientes);

                nifTXT.Text = "";
                nomeTXT.Text = "";
                profissaoTXT.Text = "";
                empresaTXT.Text = "";
                emailTXT.Text = "";
                telemovelTXT.Text = "";
                enderecoTXT.Text = "";
                cidadeTXT.Text = "";
                paisTXT.Text = "";
            }
           
        }

        public bool ContemApenasNumeros(string texto)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            return regex.IsMatch(texto);
        }
    }
}