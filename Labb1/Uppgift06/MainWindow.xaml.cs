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

namespace Uppgift06
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

        #region ClearForm
        private void ClearForm()
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResult.Clear();
            lblResult.Content = "";
        }
        #endregion

        #region Math
        private double GetSum(double num1, double num2)
        {
            double result = Math.Round(num1 + num2, 2);
            lblResult.Content = "Summa";

            return result;
        }

        private double GetDiff(double num1, double num2)
        {
            double result = Math.Round(num1 - num2, 2);
            lblResult.Content = "Differens";

            return result;
        }

        private double GetProduct(double num1, double num2)
        {
            double result = Math.Round(num1 * num2, 2);
            lblResult.Content = "Produkt";

            return result;
        }

        private double GetQuotient(double num1, double num2)
        {
            double result = Math.Round(num1 / num2, 2);
            lblResult.Content = "Kvot";

            return result;
        }
        #endregion

        #region ErrorMessage
        private void ErrorMessage()
        {
            MessageBox.Show("Vänligen fyll i alla fält och notera att endast siffror är tillåtna värden.");
        }
        #endregion

        private void btnPlus_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                txtResult.Text = GetSum((double.Parse(txtNum1.Text)), double.Parse(txtNum2.Text)).ToString();
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtResult.Text = GetDiff((double.Parse(txtNum1.Text)), double.Parse(txtNum2.Text)).ToString();

            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtResult.Text = GetProduct((double.Parse(txtNum1.Text)), double.Parse(txtNum2.Text)).ToString();
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtResult.Text = GetQuotient((double.Parse(txtNum1.Text)), double.Parse(txtNum2.Text)).ToString();
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }
    }
}
