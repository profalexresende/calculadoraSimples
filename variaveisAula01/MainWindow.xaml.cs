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

namespace variaveisAula01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declaração das Variáveis
        double n1, n2, resultado;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, RoutedEventArgs e)
        {
            //Entrada de dados
            n1 = Convert.ToDouble(txtNumero1.Text);//efetuando a conversão de string para double
            n2 = Convert.ToDouble(txtNumero2.Text);

            //Efetuando o cálculo
            resultado = n1 + n2;

            //Saída de dados
            lblResposta.Content ="Soma: " + resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            //Entrada de dados
            n1 = Convert.ToDouble(txtNumero1.Text);//efetuando a conversão de string para double
            n2 = Convert.ToDouble(txtNumero2.Text);

            //Efetuando o cálculo
            resultado = n1 * n2;

            //Saída de dados
            lblResposta.Content = "Multiplicação: " + resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, RoutedEventArgs e)
        {
            
            //Entrada de dados
            n1 = Convert.ToDouble(txtNumero1.Text);//efetuando a conversão de string para double
            n2 = Convert.ToDouble(txtNumero2.Text);

            //Efetuando o cálculo
            resultado = n1 - n2;

            //Saída de dados
            lblResposta.Content = "Subtração: " + resultado.ToString();
        }

        private void btnDividir_Click(object sender, RoutedEventArgs e)
        {
            
            //Entrada de dados
            n1 = Convert.ToDouble(txtNumero1.Text);//efetuando a conversão de string para double
            n2 = Convert.ToDouble(txtNumero2.Text);

            //Efetuando o cálculo
            resultado = n1 / n2;

            //Saída de dados
            lblResposta.Content = "Divisão: " + resultado.ToString();
        }
    }
}
