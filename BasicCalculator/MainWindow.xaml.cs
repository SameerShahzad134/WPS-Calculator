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
 
namespace BasicCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num1, num2;
        double ans;
        char operation;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            result.Text = btn.Content.ToString();
            num2 = Int32.Parse(result.Text);
        }
        private void divide_Click(object sender, RoutedEventArgs e)
        {
            num1 = Int32.Parse(result.Text);
            operation = '/';
            result.Clear();
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            num1 = Int32.Parse(result.Text);
            operation = '*';
            result.Clear();
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            num1 = Int32.Parse(result.Text);
            operation = '-';
            result.Clear();
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            num1 = Int32.Parse(result.Text);
            operation = '+';
            result.Clear();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            result.Clear();
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            num2 = Int32.Parse(result.Text);
            ans = 0;
            if (operation == '+')
            {
                ans = num1 + num2;
            }
            else if (operation == '-')
            {
                ans = num1 - num2;
            }
            else if (operation == '*')
            {
                ans = num1 * num2;
            }
            else if (operation == '/')
            {
                ans = num1 / num2;
            }
            else if (operation == '0')
            {
                result.Clear();
            }
            result.Text = ans.ToString();

        }

       

    }
}