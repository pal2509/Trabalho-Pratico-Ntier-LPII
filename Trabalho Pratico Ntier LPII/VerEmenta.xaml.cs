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

namespace Trabalho_Pratico_Ntier_LPII
{
    /// <summary>
    /// Interaction logic for VerEmenta.xaml
    /// </summary>
    public partial class VerEmenta : Window
    {
        public VerEmenta()
        {
            InitializeComponent();
            ementa.ItemsSource = ControloEmenta.GetEmenta();
            NProdutos.Text = ControloEmenta.NProdutos();
        }

        private void Voltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
