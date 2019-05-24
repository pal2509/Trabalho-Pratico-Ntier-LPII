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
        }

        private void Adcli_Click(object sender, RoutedEventArgs e)
        {
            AddCliente add = new AddCliente();
            add.Show();
            this.Close();
        }


    }
}
