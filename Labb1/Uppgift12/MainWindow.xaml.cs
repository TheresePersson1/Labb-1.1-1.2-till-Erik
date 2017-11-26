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

namespace Uppgift12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] values = new int[5];
        bool[] notTaken = new bool[5];

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Methods
        private void SaveUserInput(int number)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (notTaken[i] == false)
                {
                    values[i] = number;
                    notTaken[i] = true;
                    break;
                }
            }
        }

        private void ClearInput()
        {
            txtNum.Clear();
            txtNum.Focus();
        }

        private void ClearForm()
        {
            txtAverage.Clear();
            lbxValues.ItemsSource = null;
            btnOk.IsEnabled = true;
        }

        private void EmptyArrays()
        {
            Array.Clear(values, 0, values.Length);
            Array.Clear(notTaken, 0, notTaken.Length);
        }
        #endregion

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lblError.Content = string.Empty;
                int number = int.Parse(txtNum.Text);
                SaveUserInput(number);
                lbxValues.ItemsSource = null;
                lbxValues.ItemsSource = values;
                ClearInput();
                if (notTaken[4] == true)
                {
                    btnOk.IsEnabled = false;
                }

                txtAverage.Text = values.Average().ToString();
            }
            catch (Exception)
            {
                lblError.Content = "Vänligen fyll i ett heltal.";
            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
            EmptyArrays();
        }
    }
}
