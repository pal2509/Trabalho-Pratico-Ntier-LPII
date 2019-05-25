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
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }



        private void Registar_Click(object sender, RoutedEventArgs e)
        {
            bool z = int.TryParse(numcli.Text, out int num);
            bool x = int.TryParse(Codigos.Text, out int n);
            List<int> codigos = new List<int>();
            while(n>0)
            {
                codigos.Add(n % 1000);
                n = n / 1000;
            }
            bool y = ControloClientes.ExisteCliente(num);

            ControloRefeicoes.AddRefeicao(new Refeicao(num, codigos));
        }

        private void Ementa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
