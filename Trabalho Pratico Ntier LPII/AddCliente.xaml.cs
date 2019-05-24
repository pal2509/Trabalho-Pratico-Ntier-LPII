using BLRestaurante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BORestaurante;

namespace Trabalho_Pratico_Ntier_LPII
{
    /// <summary>
    /// Interaction logic for AddCliente.xaml
    /// </summary>
    public partial class AddCliente : Window
    {
        public AddCliente()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Registar_Click(object sender, RoutedEventArgs e)
        {
            string nome = (string)NomeCli.Text;
            bool x = int.TryParse(TelCli.Text, out int tel);
            if (x)
            {
                int n = ControloClientes.AddCliente(new Cliente(nome, tel));
                if (n == 1) MessageBox.Show("Adicionado com sucesso!!!");
                else MessageBox.Show("Cliente já registado.");
            }
            else
            {
                MessageBox.Show("Não é um numero de telefone/telemóvel!!!");
            }  
        }
    }
}
