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
using BLRestaurante;
using BORestaurante;

namespace Trabalho_Pratico_Ntier_LPII
{
    /// <summary>
    /// Interaction logic for AddReserva.xaml
    /// </summary>
    public partial class AddReserva : Window
    {
        public AddReserva()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ControloClientes.GuardarDados();
            }
            catch (Exception t)
            {
                MessageBox.Show(string.Format("{0}", t));
            }
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Registar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = ControloReservas.CriaReserva(TelCli.Text, numpes.Text, data.Text, out Reserva r);
                if (x == 1)
                {
                    int n = ControloReservas.AddReserva(r);
                    if (n == 1) MessageBox.Show("Adicionado com sucesso");
                    else if (n == 0) MessageBox.Show("Já existe uma reserva igual");
                    else MessageBox.Show("Já existem muitas reservas nessa data");
                }
                if (x == -1) MessageBox.Show("Não é um numero de telefone!!!");
                if (x == -2) MessageBox.Show("Não é um numero de pessoas!!!");
                if (x == -3) MessageBox.Show("Não é uma data!!!");
            }
            catch(Exception t)
            {
                MessageBox.Show(string.Format("{0}",t));
            }
        }
    }
}
