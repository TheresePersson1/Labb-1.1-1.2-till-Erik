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

namespace Uppgift07
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

        #region HandOutMethods
        private int HandOutCandy(int qtyCandy, int qtyPerson)
        {
            return qtyCandy / qtyPerson;
        }

        private int HandOutRemainder(int qtyCandy, int qtyPerson)
        {
            return qtyCandy % qtyPerson;
        }
        #endregion

        #region ClearForm
        private void ClearForm()
        {
            txtCandy.Clear();
            txtInt.Clear();
            txtPerson.Clear();
            txtRemain.Clear();
            lblQtyPersonRemain.Content = "";
        }
        #endregion

        #region ErrorMessage
        private void ErrorMessage()
        {
            MessageBox.Show("Vänligen fyll i alla fält och notera att endast siffror är tillåtna värden.");
        }
        #endregion

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int candy = int.Parse(txtCandy.Text);
                int person = int.Parse(txtPerson.Text);

                txtInt.Text = HandOutCandy(candy, person).ToString();
                txtRemain.Text = HandOutRemainder(candy, person).ToString();
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        } 

        private void btnHandOutRem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lblQtyPersonRemain.Content = HandOutRemainder((int.Parse(txtRemain.Text)), int.Parse(txtPerson.Text)).ToString() + " personer får godis i andra utdelningen.";
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }
    }
}
