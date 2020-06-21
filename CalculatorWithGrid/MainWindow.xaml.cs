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

namespace CalculatorWithGrid
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;

        public MainWindow()
        {
            InitializeComponent();

            resultLabel.Content = "0"; // Assegna direttamente dal codice un valore stringa alla label

            buttonAC.Click += ButtonAC_Click; // creare evento click da codice c# invece che da XAML
            buttonNegative.Click += ButtonNegative_Click;
            buttonPercentage.Click += ButtonPercentage_Click;
            buttonEqual.Click += ButtonEqual_Click;
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonPercentage_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out result))
            {
                lastNumber = result / 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void ButtonNegative_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(resultLabel.Content.ToString(),out result))
            {
                lastNumber = result * -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void ButtonAC_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }


        private void ButtonDivision_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonSeven_Click(object sender, RoutedEventArgs e)
        {
            if(resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "7";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}7"; //${NomeDellaPropertyChesiVuoleUtilizzare}
            }
        }

        private void ButtonEight_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "8";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}8"; //${NomeDellaPropertyChesiVuoleUtilizzare}
            }
        }

        private void ButtonNine_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "9";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}9"; //${NomeDellaPropertyChesiVuoleUtilizzare}
            }
        }

        private void ButtonTimes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonFour_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "4";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}4"; //${NomeDellaPropertyChesiVuoleUtilizzare}
            }
        }

        private void ButtonFive_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "5";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}5"; //${NomeDellaPropertyChesiVuoleUtilizzare}
            }
        }

        private void ButtonSix_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "6";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}6"; //${NomeDellaPropertyChesiVuoleUtilizzare}
            }
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonOne_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "1";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}1"; //${NomeDellaPropertyChesiVuoleUtilizzare}
            }
        }

        private void ButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "2";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}2"; //${NomeDellaPropertyChesiVuoleUtilizzare}
            }
        }

        private void ButtonThree_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "3";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}3"; //${NomeDellaPropertyChesiVuoleUtilizzare}
            }
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonZero_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "0";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}0"; //${NomeDellaPropertyChesiVuoleUtilizzare}
            }
        }

        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
