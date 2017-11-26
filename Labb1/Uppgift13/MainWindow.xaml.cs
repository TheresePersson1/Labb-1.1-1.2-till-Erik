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

namespace Uppgift13
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

        public int CountLetters(string text, char letter)
        {
            int qty = 0;

            foreach (char ch in text.ToLower())
            {
                if (ch == letter)
                {
                    qty++;
                }
            }
            return qty;
        }

        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string text = txtText.Text;
                char letter = char.Parse(txtLetter.Text);               
                lblResult.Content = "Bokstaven " + letter + " hittades " + CountLetters(text, letter) + " gånger." ;
            }
            catch (Exception)
            {
                MessageBox.Show("Hallå där! Jag kan inte räkna tecken om du inte ger mig något att leka med =)");
            }
        }
    }
}
