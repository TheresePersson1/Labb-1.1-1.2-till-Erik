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

namespace Uppgift09
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

        #region VerifyAge
        private string VerifyAgeLimit(string name, int age)
        {
            string message = "Hej " + name + ". Du är " + age + " gammal och får se filmer";

            if(rbtWithoutAdult.IsChecked == true)
            {
                if (age < 7 && age >= 0)
                {
                    message = message += " som är barntillåtna.";
                }
                else if (age < 11 && age >= 7)
                {
                    message = message += " med åldersgräns upp till 7 år.";
                }
                else if (age < 15 && age >= 11)
                {
                    message = message += " med åldersgräns upp till 11 år.";
                }
                else if (age >= 15 && age < 150)
                {
                    message = message += " i alla kategorier..";
                }
                else
                {
                    message = "Nej, " + name + " nu skojar du med mig.";
                }
            }
            else if(rbtnWithAdult.IsChecked == true)
            {
                if (age < 7 && age >= 0)
                {
                    message = message += " med en åldersgräns upp till 7 år eftersom du har en vuxen med dig.";
                }
                else if (age < 11 && age >= 7)
                {
                    message = message += " med en åldersgräns upp till 11 år eftersom du har en vuxen med dig.";

                }
                else if (age < 15 && age >= 11)
                {
                    message = message += " med åldersgräns upp till 11 år. 15-årsgränsen gäller trots att du är i vuxens sällskap";
                }
                else if (age >= 15 && age < 150)
                {
                    message = message += " i alla kategorier.";
                }
                else
                {
                    message = "Nej, " + name + " nu skojar du med mig.";
                }
                if (age < 11 && age >= 7)
                {
                }
                
            }
            else
            {
                message = "Vänligen välj med eller utan vuxen innan kontroll utförs.";
            }

            return message;
        }
        #endregion

        #region ErrorMessages
        private void ValidateInputLettersOnly(string input)
        {
            if (Regex.IsMatch(input, @"^[a-zA-Z]+$") == false)
            {
                MessageBox.Show("Endast bokstäver är tillåtna i Namnfält.");
            }
        }

        private void FieldInputMissing()
        {
            MessageBox.Show("Vänligen kontrollera dina inmatningar.");
        }
        #endregion

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ValidateInputLettersOnly(txtName.Text);
                txtBlMessage.Text = VerifyAgeLimit(txtName.Text, int.Parse(txtAge.Text));
            }
            catch (Exception)
            {
                FieldInputMissing();
            }
        }
    }
}
