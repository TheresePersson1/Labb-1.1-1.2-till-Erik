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

namespace Uppgift11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        public MainWindow()
        {
            InitializeComponent();
            slider.Value = 50;
        }

        //Funkar finfint men inte med outursfaktorn...så
        //jag bygger om
        //private int CheckIncidenceLuck(double tries)
        //{
        //    int randValue, correct = 0;

        //    for (int i = 0; i < tries; i++)
        //    {
        //        randValue = rand.Next(2);

        //        if (randValue == 0)
        //        {
        //            correct++;
        //        }  
        //    }
        //    return correct;
        //}

        #region Methods
        private int CheckIncidenceBadLuck(int tries)
        {
            int badLuckFactor = (int)slider.Value;
            int randValue, wrong = 0, correct = 0;

            for (int i = 0; i < tries; i++)
            {
                randValue = rand.Next(0, 101);

                if(randValue <= badLuckFactor)
                {
                    wrong++;
                }
                else if(randValue >= badLuckFactor)
                {
                    correct++;
                }
            }
            return wrong;
        }
        #endregion

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int tries = int.Parse(txtTries.Text);
                int wrong = CheckIncidenceBadLuck(tries);
                lblQtyWrong.Content = wrong;
                lblQtyCorrect.Content = tries - wrong;
                lblError.Content = string.Empty;
            }
            catch (Exception)
            {
                lblError.Content = "Vänligen fyll i antal försök.";
            }

        }

        private void btnMore_Click(object sender, RoutedEventArgs e)
        {
            slider.Value += 5;
        }

        private void btnLess_Click(object sender, RoutedEventArgs e)
        {
            slider.Value -= 5;
        }
    }
}
