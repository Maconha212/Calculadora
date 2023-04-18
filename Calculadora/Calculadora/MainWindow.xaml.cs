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

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string operador;
        private double num1, num2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, RoutedEventArgs e)
        {
            string numero = (sender as Button).Content.ToString();

            if (txtResultado.Text == "0")
                txtResultado.Text = numero;
            else
                txtResultado.Text += numero;
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void btnOperador_Click(object sender, RoutedEventArgs e)
        {
            operador = (sender as Button).Content.ToString();
            num1 = double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            num2 = double.Parse(txtResultado.Text);

            switch (operador)
            {
                case "+":
                    txtResultado.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    txtResultado.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    txtResultado.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    if (num2 != 0)
                        txtResultado.Text = (num1 / num2).ToString();
                    else
                        txtResultado.Text = "Erro";
                    break;
            }
        }

        private void btnPonto_Click(object sender, RoutedEventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
                txtResultado.Text += ".";
        }
    }


}