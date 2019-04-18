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

namespace Proj3_Hernandez
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        // Instantiate VendingMachine object.
        VendingMachine vm = new VendingMachine();

        public MainWindow()
        {
            InitializeComponent();

            txtMoney.Text = (vm.NumQuarters * .25 ).ToString("C");
            txtTwixAmt.Text = vm.TwixBar.ToString();
            txtKitkatAmt.Text = vm.KitkatBar.ToString();
            txtHersheysAmt.Text = vm.HersheysBar.ToString();
            txtReesesAmt.Text = vm.ReesesCups.ToString();
            txtTotalVended.Text = vm.NumCandyBars.ToString();




        }

        // 4 click events for every bar that update the text boxes around them, including
        // the amount of money, the number of bars dispensed, and the number of each candy bar
        private void btnTwix_Click(object sender, RoutedEventArgs e)
        {
            

            if (vm.NumQuarters >= 3 && vm.TwixBar > 0)
            {
                vm.SelectTwix();
                MessageBox.Show("Twix Bar Dispensed");
            }
            else if (vm.TwixBar > 0)
            {
                MessageBox.Show("Not enough quarters to buy a Twix bar.");
            }
            else
            {
                MessageBox.Show("No Twixs bars in machine.");
            }

            txtTwixAmt.Text = vm.TwixBar.ToString();
            txtMoney.Text = (vm.NumQuarters * .25).ToString("C");
            txtTotalVended.Text = vm.NumCandyBars.ToString();
        }

        private void btnKitkat_Click(object sender, RoutedEventArgs e)
        {
            

            if (vm.NumQuarters >= 4 && vm.KitkatBar > 0)
            {
                vm.SelectKitkat();
                MessageBox.Show("KitKat Bar Dispensed");
            }
            else if (vm.KitkatBar > 0)
            {
                MessageBox.Show("Not enough quarters to buy a KitKat bar.");
            }
            else
            {
                MessageBox.Show("No KitKat bars in machine.");
            }

            txtKitkatAmt.Text = vm.KitkatBar.ToString();
            txtMoney.Text = (vm.NumQuarters * .25).ToString("C");
            txtTotalVended.Text = vm.NumCandyBars.ToString();

        }

        private void btnHersheys_Click(object sender, RoutedEventArgs e)
        {
            

            if (vm.NumQuarters >= 5 && vm.HersheysBar > 0)
            {
                vm.SelectHersheys();               
                MessageBox.Show("Hershey's Bar Dispensed");
            }
            else if (vm.HersheysBar > 0)
            {
                MessageBox.Show("Not enough quarters to buy a Hershey's bar.");
            }
            else
            {
                MessageBox.Show("No Hershey's bars in machine.");
            }

            txtHersheysAmt.Text = vm.HersheysBar.ToString();
            txtMoney.Text = (vm.NumQuarters * .25).ToString("C");
            txtTotalVended.Text = vm.NumCandyBars.ToString();
        }

        private void btnReeses_Click(object sender, RoutedEventArgs e)
        {


            if (vm.NumQuarters >= 6 && vm.ReesesCups > 0)
            {
                vm.SelectReeses();
                MessageBox.Show("Reese's Cups Dispensed");
            }
            else if (vm.ReesesCups > 0)
            {
                MessageBox.Show("Not enough quarters to buy Reese's Cups.");
            }
            else
            {
                MessageBox.Show("No Reese's Cups in machine.");
            }

            txtReesesAmt.Text = vm.ReesesCups.ToString();
            txtMoney.Text = (vm.NumQuarters * .25).ToString("C");
            txtTotalVended.Text = vm.NumCandyBars.ToString();
        }


        //Deposit Quarter Method that update the text box next to it
        private void btnDeposit_Click(object sender, RoutedEventArgs e)
        {
            vm.DepositQuarter();
            txtMoney.Text = (vm.NumQuarters * .25).ToString("C");       

        }
    }
}
