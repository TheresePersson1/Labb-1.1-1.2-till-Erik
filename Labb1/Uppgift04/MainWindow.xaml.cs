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

namespace Uppgift04
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


        private void GetDay(string day)
        {
            lblResult.Content = "Du klickade på knappen " + day;
        }

        private void btnMonday_Click(object sender, RoutedEventArgs e)
        {            
            GetDay(btnMonday.Content.ToString());                  
        }

        private void btnTuesday_Click(object sender, RoutedEventArgs e)
        {
            GetDay(btnTuesday.Content.ToString());
        }

        private void btnWednesday_Click(object sender, RoutedEventArgs e)
        {
            GetDay(btnWednesday.Content.ToString());
        }

        private void btnThursday_Click(object sender, RoutedEventArgs e)
        {
            GetDay(btnThursday.Content.ToString());
        }

        private void btnFriday_Click(object sender, RoutedEventArgs e)
        {
            GetDay(btnFriday.Content.ToString());
        }

        private void btnSaturday_Click(object sender, RoutedEventArgs e)
        {
            GetDay(btnSaturday.Content.ToString());
        }

        private void btnSunday_Click(object sender, RoutedEventArgs e)
        {
            GetDay(btnSunday.Content.ToString());
        }
    }
}
