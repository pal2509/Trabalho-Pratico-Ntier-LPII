using BLRestaurante;
using BORestaurante;
using System;
using System.Windows;

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
            clientes.ItemsSource = ControloClientes.GetClientes();
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
