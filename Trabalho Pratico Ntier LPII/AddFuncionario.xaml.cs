using BLRestaurante;
using BORestaurante;
using System;
using System.Windows;

namespace Trabalho_Pratico_Ntier_LPII
{
    /// <summary>
    /// Interaction logic for AddFuncionario.xaml
    /// </summary>
    public partial class AddFuncionario : Window
    {
        public AddFuncionario()
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
            bool x = int.TryParse(funcao.Text, out int n);
            bool z = int.TryParse(Tel.Text, out int tel);
            if (x == true && z == true) 
            {
                bool y = ControloFunc.GetFuncao(n, out Funcao f);
                if (y == true) ControloFunc.AddFunc(new Funcionario(Nome.Text, tel, f));
                else MessageBox.Show("A função não existe!!!");
            }
            if (x == false) MessageBox.Show("Não é um numero!!!");
            if (z == false) MessageBox.Show("Não é um numero de telefone!!!");
        }

        
    }
}
