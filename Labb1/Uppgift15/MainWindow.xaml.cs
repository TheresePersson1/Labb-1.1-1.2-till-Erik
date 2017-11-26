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

namespace Uppgift15
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
        private bool IsVowelUpperCase(char letter)
        {
            bool isVowelUpper = false;

            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö' };

            for (int i = 0; i < vowels.Length; i++)
            {
                if(letter == vowels[i])
                {
                    isVowelUpper = true;
                    break;
                }
            }
            return isVowelUpper; 
        }

        private bool IsVowelLowerCase(char letter)
        {
            bool isVowelLower = false;

            char[] vowels= new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

            for (int i = 0; i < vowels.Length; i++)
            {
                if (letter == vowels[i])
                {
                    isVowelLower = true;
                    break;
                }
            }
            return isVowelLower;           
        }

        private bool IsVowel(char letter)
        {
            bool isVowel = false;

            if(IsVowelUpperCase(letter) == true)
            {
                isVowel = true;
            }
            else if(IsVowelLowerCase(letter) == true)
            {
                isVowel = true;
            }

            return isVowel;
        }

        private int CountVowels(string text) 
        {
            int qty = 0;

            foreach (char ch in text)
            {
                if(IsVowelUpperCase(ch) == true)
                {
                    qty++;
                }
                else if(IsVowelLowerCase(ch) == true)
                {
                    qty++;
                }
            }
            return qty;       
        }

        private string TranslateToGibberish(string text)
        {
            char[] replacement = text.ToCharArray();

            for (int i = 0; i < replacement.Length; i++)
            {
                if(IsVowelUpperCase(replacement[i]) == true)
                {
                    replacement[i] = 'Ö';
                }
                else if (IsVowelLowerCase(replacement[i]) == true)
                {
                    replacement[i] = 'ö';
                }
            }
            string reMadeText = new string(replacement);
            return reMadeText;
        }

        private string TranslateToBandalero(string text)
        {
            char[] replacement = text.ToCharArray();
            List<char> newText = new List<char>();

            for (int i = 0; i < replacement.Length; i++)
            {
                newText.Add(replacement[i]);

                if (char.IsWhiteSpace(replacement[i]) || char.IsPunctuation(replacement[i]))
                {

                }
                else if (IsVowel(replacement[i]) == false)
                {
                    newText.Add('o');
                    newText.Add(replacement[i]);
                }
            }
            string finalText = new string(newText.ToArray());
            return finalText;
        }

        private void ClearForm()
        {
            txtBaseText.Clear();
            textBlockOutput.Text = string.Empty;
            lblQty.Content = string.Empty;
        }
        #endregion

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            {
                string text = txtBaseText.Text;
                lblQty.Content = CountVowels(text);
                textBlockOutput.Text = TranslateToGibberish(text);
            }
        }

        private void btnConvertBandelero_Click(object sender, RoutedEventArgs e)
        {
            lblLanguage.Content = "Rövarspråk";
            string text = txtBaseText.Text;
            lblQty.Content = CountVowels(text);
            textBlockOutput.Text = TranslateToBandalero(text);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }
    }
}
