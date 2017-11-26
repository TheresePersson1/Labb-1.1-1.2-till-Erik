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

namespace Uppgift14
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

        #region Methods
        private bool ValidateDigitsOnly(string input)
        {
            bool letter = false;
            foreach (char ch in input)
            {
                if (!char.IsLetter(ch))
                {
                    return true;
                }
            }
            return letter;
        }

        private int CalculateAge(string input)
        {
            int age = 0;

            int birthYear = int.Parse(input);

            age = DateTime.Now.Year - birthYear;

            return age;
        }

        private string Message(string input)
        {
            string message = "";

            if(ValidateDigitsOnly(input) == false)
            {
               message = "Du måste mata in enbart siffror.";
            }
            else
            {
                message = "Du är " + CalculateAge(input) + " år gammal.";
            }
            return message;
        }
        #endregion

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            string birthYear = txtAge.Text;
            int age = CalculateAge(birthYear);
            MessageBox.Show(Message(birthYear.ToString()));
        }
    }
}
