using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Uppgift02
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

        private void ValidateInputOnyLetters(string input)
        {
            if(Regex.IsMatch(input, @"^[a-zA-Z]+$") == false)
            {
                MessageBox.Show("Endast bokstäver är tillåtna i Namnfält.");
            }
            else
            {
                MessageBox.Show("Hej " + input +"! Hoppas du mår bra.");
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            ValidateInputOnyLetters(txtName.Text);              
        }
    }
}
