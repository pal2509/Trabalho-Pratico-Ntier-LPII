using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using BLRestaurante;
using BORestaurante;
using Varios;

namespace Trabalho_Pratico_Ntier_LPII
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                ControloClientes.CarregarDados();
            }
            catch (Exception t)
            {
                MessageBox.Show(string.Format("{0}", t));
            }
        }

        private void Adcli_Click(object sender, RoutedEventArgs e)
        {
            AddCliente add = new AddCliente();
            add.Show();
            this.Close();
        }

        private void Adres_Click(object sender, RoutedEventArgs e)
        {
            AddReserva add = new AddReserva();
            add.Show();
            this.Close();
        }

        private void Adref_Click(object sender, RoutedEventArgs e)
        {
            AddRefei add = new AddRefei();
            add.Show();
            this.Close();
        }

        private void Adpro_Click(object sender, RoutedEventArgs e)
        {
            AddProduto add = new AddProduto();
            add.Show();
            this.Close();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                ControloClientes.GuardarDados();
            }
            catch (Exception t)
            {
                MessageBox.Show(string.Format("{0}", t));
            }
        }

        private void Add_Func(object sender, RoutedEventArgs e)
        {
            AddFuncionario add = new AddFuncionario();
            add.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VerClientes ver = new VerClientes();
            ver.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            VerReservas ver = new VerReservas();
            ver.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            VerRefeicoes ver = new VerRefeicoes();
            ver.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            VerEmenta ver = new VerEmenta();
            ver.Show();
            this.Close();
        }

        private void VerFunc(object sender, RoutedEventArgs e)
        {
            VerFuncionarios ver = new VerFuncionarios();
            ver.Show();
            this.Close();
        }
    }
}
