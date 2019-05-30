/*
 * Autor:Paulo Meneses
 * Numero:17611
 * Trabalho Prático de linguagem de programação 2
 */
using BLRestaurante;
using BORestaurante;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Trabalho_Pratico_Ntier_LPII
{
    /// <summary>
    /// Interaction logic for AddProduto.xaml
    /// </summary>
    public partial class AddProduto : Window
    {
        public AddProduto()
        {
            InitializeComponent();
            ementa.ItemsSource = ControloEmenta.GetEmenta();
            
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
                int x = ControloEmenta.CriaEmenta( nome.Text, preco.Text, out Produto r);
                if (x == 1)
                {
                    int n = ControloEmenta.AddProduto(r);
                    if (n == 1) MessageBox.Show("Adicionado com sucesso");
                    else MessageBox.Show("Já existe um produto igual");
                    
                }
                
                if (x == -2) MessageBox.Show("Não é um preço válido!!!");
                
            }
            catch (Exception t)
            {
                MessageBox.Show(string.Format("{0}", t));
            }
        }

        private void Ementa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }
    }
}
