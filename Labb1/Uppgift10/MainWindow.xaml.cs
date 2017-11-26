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

namespace Uppgift10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();

        int randNum = 0;
        int guessCount = 0;
        public MainWindow()
        {
            InitializeComponent();            
        }

        #region Methods
        private string CheckGuess(int guess)
        {
            string message = "";
            if (guess > randNum + 100)
            {
                message = "Din gissning är alldeles för stor.";
            }
            else if (guess < randNum - 100)
            {
                message = "Din gissning är alldeles för liten.";
            }
            else if (guess > randNum)
            {
                message = "Din gissning är för stor.";
            }
            else if (guess < randNum)
            {
                message = "Din gissning är för liten.";
            }
            else
            {
                message = "Du har gissat rätt. Grattis! Du klarade detta på " +  guessCount + " försök.";
            }
            return message;

        }

        #endregion

        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            randNum = rand.Next(1001);
            btnGuess.IsEnabled = true;
            btnRandom.IsEnabled = false;
        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                guessCount++;
                txtBlResult.Text = CheckGuess(int.Parse(txtGuess.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Fältet kan inte vara tomt och gissningar kan endast bestå av siffror.");
            }
                    
        }
    }
}
