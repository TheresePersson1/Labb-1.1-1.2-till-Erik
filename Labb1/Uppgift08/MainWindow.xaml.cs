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

namespace Uppgift08
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

        #region Calculate
        private double Calculate(double num1, double num2)
        {
            double result = 0;

            if (rbtnPlus.IsChecked == true)
            {
                result = num1 + num2;
            }
            else if(rbtnMin.IsChecked == true)
            {
                result = num1 - num2;
            }
            else if(rbtnMult.IsChecked == true)
            {
                result = num1 * num2;
            }
            else if(rbtnDiv.IsChecked == true)
            {
                result = num1 / num2;
            }
            else
            {
                ErrorMessageRadio();
            }
            return Math.Round(result, 2);
        }
        #endregion

        #region ErrorMessages
        private void ErrorMessageFieldInput()
        {
            MessageBox.Show("Vänligen fyll i alla fält och notera att endast siffror är tillåtna värden.");
        }

        private void ErrorMessageRadio()
        {
            MessageBox.Show("Du har inte valt räknesätt");
        }
        #endregion

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtResult.Text = Calculate((double.Parse(txtNum1.Text)), double.Parse(txtNum2.Text)).ToString();
            }
            catch (Exception)
            {
                ErrorMessageFieldInput();
            }
        }
    }
}
