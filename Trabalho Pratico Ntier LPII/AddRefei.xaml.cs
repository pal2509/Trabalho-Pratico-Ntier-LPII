﻿using System;
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
    /// Interaction logic for AddRefei.xaml
    /// </summary>
    public partial class AddRefei : Window
    {
        public AddRefei()
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
            bool z = int.TryParse(numcli.Text, out int num);
            bool x = int.TryParse(Codigos.Text, out int n);
            bool a = false;
            List<int> codigos = new List<int>();
            while(n>0)
            {
                int b = n % 1000;
                a = ControloEmenta.ExisteProduto(b);
                if (a == true) codigos.Add(b);
                else MessageBox.Show(string.Format("O codigo {0} não existe!!!", b));
                n = n / 1000;
            }
            bool y = ControloClientes.ExisteCliente(num);

            if (a == true && y == true) ControloRefeicoes.AddRefeicao(new Refeicao(num, codigos));
            else if (y == false) MessageBox.Show("O codigo do cliente não existe.");
            else MessageBox.Show("Codigos dos produtos errados");
        }

        private void Ementa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
