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

namespace Machtsverheffing
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

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            getalTextBox.Text = "1";
            resultTextBox.Clear();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            bool isValidInput = double.TryParse(getalTextBox.Text, out double input);

            if (isValidInput)
            {
                if (input < 84 && input >= 0)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        double power = Convert.ToDouble(i);
                        double macht = Math.Pow(input, power);
                        resultTextBox.Text += $"Macht {i:00} van {input} is {macht}\n";
                    }
                }
                else
                {
                    resultTextBox.Text = "Getal moet positief zijn en kleiner dan 84.";
                }
            } else
            {
                resultTextBox.Text = "Invalid input.";
            }

        }

        private void getalTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            getalTextBox.Text = "1";
        }
    }
}
