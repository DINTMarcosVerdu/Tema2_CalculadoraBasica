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

namespace Ejercicio_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            resultado.Text = "";
            operador.Text = "";
            operando1.Text = "";
            Operando2.Text = "";
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (operador.Text)
                {
                    case "+":
                        resultado.Text = (double.Parse(operando1.Text) + double.Parse(Operando2.Text)).ToString();
                        break;
                    case "-":
                        resultado.Text = (double.Parse(operando1.Text) - double.Parse(Operando2.Text)).ToString();
                        break;
                    case "*":
                        resultado.Text = (double.Parse(operando1.Text) * double.Parse(Operando2.Text)).ToString();
                        break;
                    case "/":
                        resultado.Text = (double.Parse(operando1.Text) / double.Parse(Operando2.Text)).ToString();
                        break;
                    default:
                        break;
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error 404: " + exc.Message, Title, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
            

        }

        private void operador_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (operador.Text == "+" || operador.Text == "-" || operador.Text == "*" || operador.Text == "/")
                calcularButton.IsEnabled = true;
            else
                calcularButton.IsEnabled = false;
            

            
        }
    }
}
