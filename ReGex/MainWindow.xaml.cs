using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace ExperimentoReGex
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

        int count = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var eV = @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$";
            var tV = @"^(?:\+)[0-9]{2}\s?(?:\()[0-9]{2}(?:\))\s?[0-9]{4,5}(?:-)[0-9]{4}$";

            Regex emailValidator = new Regex(eV);
            Regex telValidador = new Regex(tV);



            if (emailValidator.IsMatch(txtEmail.Text) && telValidador.IsMatch(txtTelefone.Text))
            {
                MessageBox.Show("Email e Telefone Válidos");
            }
            else
                MessageBox.Show("Email ou Telefone Invalidos");



        }

        private void TxtTelefone_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (count < txtTelefone.Text.Length)
            {
                count++;
                if (count == 1)
                {
                    count++;
                    txtTelefone.Text = "+" + txtTelefone.Text;
                    txtTelefone.CaretIndex = txtTelefone.Text.Length;
                }
                if (count == 3)
                {
                    count++;
                    txtTelefone.Text = txtTelefone.Text + " (";
                    txtTelefone.CaretIndex = txtTelefone.Text.Length;
                }
                if (count == 7)
                {
                    count++;
                    txtTelefone.Text = txtTelefone.Text + ") ";
                    txtTelefone.CaretIndex = txtTelefone.Text.Length;
                }
                if (count == 14)
                {
                    count++;
                    txtTelefone.Text = txtTelefone.Text + "-";
                    txtTelefone.CaretIndex = txtTelefone.Text.Length;
                }

            }
            else if (count > txtTelefone.Text.Length)
                count--;





                
        }
    }
}
