using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Text;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculatorApp
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

        double result;

        public void sum_Click(object sender, RoutedEventArgs e)
        {
            //Declaring variables

            double numa = Convert.ToDouble(num1.Text);
            double numb = Convert.ToDouble(num2.Text);

            string operat = "+";
            opera.Text = operat;

             result = numa + numb;

        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            double numa = Convert.ToDouble(num1.Text);
            double numb = Convert.ToDouble(num2.Text);

            string operat = "-";
            opera.Text = operat;

            result = numa - numb;
        }

        private void divi_Click(object sender, RoutedEventArgs e)
        {
            double numa = Convert.ToDouble(num1.Text);
            double numb = Convert.ToDouble(num2.Text);

            string operat = "/";
            opera.Text = operat;
            if (numb > 0)
            {
                result = numa / numb;
            }
            else
            {
                MessageBox.Show("You divided by O", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

           
        }

        private void times_Click(object sender, RoutedEventArgs e)
        {
            double numa = Convert.ToDouble(num1.Text);
            double numb = Convert.ToDouble(num2.Text);

            string operat = "*";
            opera.Text = operat;

            result = numa * numb;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {

            //The output window
            TextBlockresult.Text = Convert.ToString(result);

            //Error handling in code

        }

        
    }
}
