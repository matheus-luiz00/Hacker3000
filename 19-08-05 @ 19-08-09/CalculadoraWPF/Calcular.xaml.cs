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

namespace CalculadoraWPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Calcular : UserControl
    {
        public Calcular()
        {
            InitializeComponent();
        }
        bool primOperacao = true;
        double storage = 0;
        string sign = "";
        bool opRealizada = true;

        #region Botões_Numbers
        private void BtnSeven_Click(object sender, RoutedEventArgs e)
        {
            if (opRealizada)
            {
                visorDig.Text = "";
                opRealizada = false;
            }
            visorDig.Text += '7';
        }

        private void BtnEight_Click(object sender, RoutedEventArgs e)
        {
            if (opRealizada)
            {
                visorDig.Text = "";
                opRealizada = false;
            }
            visorDig.Text += '8';
        }

        private void BtnNine_Click(object sender, RoutedEventArgs e)
        {
            if (opRealizada)
            {
                visorDig.Text = "";
                opRealizada = false;
            }
            visorDig.Text += '9';
        }

        private void BtnZero_Click(object sender, RoutedEventArgs e)
        {
            if (opRealizada)
            {
                visorDig.Text = "";
                opRealizada = false;
            }
            visorDig.Text += '0';
        }

        private void BtnFloat_Click(object sender, RoutedEventArgs e)
        {
            string temp = visorDig.Text;
            temp += ",";
            visorDig.Text = temp;
        }

        private void BtnSign_Click(object sender, RoutedEventArgs e)
        {
            if (!visorDig.Text.Contains('-'))
                visorDig.Text = '-' + visorDig.Text;
            else
                visorDig.Text = visorDig.Text.Trim('-');

        }

        private void BtnClear_Click(object sender, RoutedEventArgs e) //Clear
        {
            visor.Text = string.Empty;
            visorDig.Text = string.Empty;
            storage = 0;
            primOperacao = true;
        }

        private void BtnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (visorDig.Text.Length > 0)
                visorDig.Text = visorDig.Text.Remove((visorDig.Text.Length - 1));
        }

        private void BtnSix_Click(object sender, RoutedEventArgs e)
        {
            if (opRealizada)
            {
                visorDig.Text = "";
                opRealizada = false;
            }
            visorDig.Text += '6';
        }

        private void BtnFive_Click(object sender, RoutedEventArgs e)
        {
            if (opRealizada)
            {
                visorDig.Text = "";
                opRealizada = false;
            }
            visorDig.Text += '5';
        }

        private void BtnFour_Click(object sender, RoutedEventArgs e)
        {
            if (opRealizada)
            {
                visorDig.Text = "";
                opRealizada = false;
            }
            visorDig.Text += '4';
        }

        private void BtnThree_Click(object sender, RoutedEventArgs e)
        {
            if (opRealizada)
            {
                visorDig.Text = "";
                opRealizada = false;
            }
            visorDig.Text += '3';
        }

        private void BtnTwo_Click(object sender, RoutedEventArgs e)
        {
            if (opRealizada)
            {
                visorDig.Text = "";
                opRealizada = false;
            }
            visorDig.Text += '2';
        }

        private void BtnOne_Click(object sender, RoutedEventArgs e)
        {
            if (opRealizada)
            {
                visorDig.Text = "";
                opRealizada = false;
            }
            visorDig.Text += '1';
        }
        #endregion

        private void BtnDivision_Click(object sender, RoutedEventArgs e)
        {
            SelecionarOperacao(sign, "/");
            sign = "/";
        }

        private void BtnMultiplication_Click(object sender, RoutedEventArgs e)
        {
            SelecionarOperacao(sign, "*");
            sign = "*";
        }

        private void BtnSubtraction_Click(object sender, RoutedEventArgs e)
        {
            SelecionarOperacao(sign, "-");
            sign = "-";
        }

        private void BtnSum_Click(object sender, RoutedEventArgs e)
        {
            SelecionarOperacao(sign, "+");
            sign = "+";
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e) //Igual
        {
            SelecionarOperacao(sign, "");
            visorDig.Text = storage.ToString();
            visor.Text = string.Empty;
            sign = string.Empty;
            storage = 0;
            opRealizada = true;
            primOperacao = true;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void CalcularResultado(string num, string op)
        {
            
            switch (op)
            {
                case "+":
                    {
                        var valorOperacao = double.Parse(num);
                        storage += valorOperacao;
                        break;
                    }
                case "-":
                    {
                        var valorOperacao = double.Parse(num);
                        storage -= valorOperacao;
                        break;
                    }
                case "/":
                    {
                        if (num != "0")
                        {
                            var valorOperacao = double.Parse(num);
                            storage = (storage / valorOperacao);
                        }
                        break;
                    }
                case "*":
                    {
                        var valorOperacao = double.Parse(num);
                        storage = (storage * valorOperacao);
                        break;
                    }
            }
        }

        private void SelecionarOperacao(string operacao, string prim)
        {
            if (string.IsNullOrEmpty(visorDig.Text)) visorDig.Text = "0";
            if (primOperacao == true)
            {

                sign = operacao;
                visor.Text = visorDig.Text + prim;
                storage = double.Parse(visorDig.Text);
                primOperacao = false;
                visorDig.Text = "";
                opRealizada = true;


            }
            else
            {
                visor.Text += visorDig.Text + operacao;
                CalcularResultado(visorDig.Text, operacao);
                sign = operacao;
                visorDig.Text = storage.ToString();
                opRealizada = true;
            }
        }
    }
}
