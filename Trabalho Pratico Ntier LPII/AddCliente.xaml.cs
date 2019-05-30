/*
 * Autor:Paulo Meneses
 * Numero:17611
 * Trabalho Prático de linguagem de programação 2
 */

using BLRestaurante;
using BORestaurante;
using System;
using System.Windows;

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
            catch (Exception t)
            {
                MessageBox.Show(string.Format("{0}", t));
            }

        }

        private void Remover_Click(object sender, RoutedEventArgs e)
        {
            bool x = int.TryParse(CodRemove.Text, out int cod);
            if (x == true)
            {
                bool y = ControloClientes.RemoveCliente(cod);
                if (y == true) MessageBox.Show("Removido com sucesso.");
                else MessageBox.Show("Cliente não existe");
            }
            else MessageBox.Show("Não é um codigo!!!");

        }
    }
}
