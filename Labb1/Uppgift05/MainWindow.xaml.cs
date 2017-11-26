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

namespace Uppgift05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtNumber1.Focus();
        }

        private int CalculateSum(int number1, int number2)
        {
            return number1 + number2;
        }

        private void ClearForm()
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            txtSum.Clear();
            txtNumber1.Focus();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtSum.Text = CalculateSum((int.Parse(txtNumber1.Text)), int.Parse(txtNumber2.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vänligen fyll i alla fält och notera att endast siffror är tillåtna värden.");
            }
            
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }
    }
}
