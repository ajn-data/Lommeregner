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

namespace Lommeregner1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            double firstInput = double.Parse(FirstInput.Text);
            double secondInput = double.Parse(SecondInput.Text);
            double result = firstInput + secondInput;
            Result.Text = result + "";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            double firstInput = double.Parse(FirstInput.Text);
            double secondInput = double.Parse(SecondInput.Text);
            double result = firstInput - secondInput;
            Result.Text = result + "";
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            double firstInput = double.Parse(FirstInput.Text);
            double secondInput = double.Parse(SecondInput.Text);
            double result = firstInput * secondInput;
            Result.Text = result + "";
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            double firstInput = double.Parse(FirstInput.Text);
            double secondInput = double.Parse(SecondInput.Text);
            double result = firstInput / secondInput;
            Result.Text = result + "";
        }

        private void btnCirkelAreal_Click(object sender, RoutedEventArgs e)
        {
            double firstInput = double.Parse(FirstInput.Text);
            double secondInput = double.Parse(SecondInput.Text);
            double result = firstInput * secondInput * 3.14;
            Result.Text = result + "";
        }

        private void btnFirkantAreal_Click(object sender, RoutedEventArgs e)
        {
            double firstInput = double.Parse(FirstInput.Text);
            double secondInput = double.Parse(SecondInput.Text);
            double result = firstInput * secondInput;
            Result.Text = result + "";
        }

        private void btnTrapezAreal_Click(object sender, RoutedEventArgs e)
        {
            double firstInput = double.Parse(FirstInput.Text);
            double secondInput = double.Parse(SecondInput.Text);
            double thirdInput = double.Parse(ThirdInput.Text);
            double result = 0.5 * (firstInput + secondInput) * thirdInput;
            Result.Text = result + "";
        }
    }
}
