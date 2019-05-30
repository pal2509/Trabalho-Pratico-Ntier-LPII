/*
 * Autor:Paulo Meneses
 * Numero:17611
 * Trabalho Prático de linguagem de programação 2
 */
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
using System.Windows.Shapes;
using BORestaurante;
using BLRestaurante;


namespace Trabalho_Pratico_Ntier_LPII
{
    /// <summary>
    /// Interaction logic for VerClientes.xaml
    /// </summary>
    public partial class VerClientes : Window
    {
        public VerClientes()
        {
            InitializeComponent();
            clientes.ItemsSource = ControloClientes.GetClientes();
            Nclientes.Text = ControloClientes.NClientes();
        }

        private void Voltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }


    }
}
