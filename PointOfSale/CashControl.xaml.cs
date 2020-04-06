using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;
using CowboyCafe.Data;
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashControl.xaml
    /// </summary>
    public partial class CashControl : UserControl, INotifyPropertyChanged
    {

        /// <summary>
        /// Notifies of property changed events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// creates a cashdrawer that is used
        /// </summary>
        CashDrawer drawer = new CashDrawer();
        /// <summary>
        /// Initializes the CashController
        /// </summary>
        public CashControl(double total)
        {
            InitializeComponent();
            
            this.DataContext = drawer;
            TotalDue = total;
            
        }

        

        public double AmountAdded { get; set; }


        public double TotalDue { get; set; }

        public double TotalLeft
        {
            get { return TotalDue - AmountAdded; }
        }

        public double TotalValue => drawer.TotalValue;

        /// <summary>
        /// Adds a Penny when button clicked to drawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Penny_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddCoin(Coins.Penny, 1);
            AmountAdded += .01;
            InvokePropertyChanged("Pennies");
            
            
        }
        /// <summary>
        /// Adds a Nickel when button clicked to drawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nickel_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddCoin(Coins.Nickel, 1);
            AmountAdded += .05; 
            InvokePropertyChanged("Nickels");
        }
        /// <summary>
        /// Adds a Dime when button clicked to drawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dime_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddCoin(Coins.Dime, 1);
            AmountAdded += .1;
            InvokePropertyChanged("Dimes");
        }
        /// <summary>
        /// Adds a Quarter when button clicked to drawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quarter_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddCoin(Coins.Quarter, 1);
            AmountAdded += .25;
            InvokePropertyChanged("Quarters");
        }
        /// <summary>
        /// Adds a Half Dollar when button clicked to drawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HalfDollar_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddCoin(Coins.HalfDollar, 1);
            AmountAdded += .50;
            InvokePropertyChanged("HalfDollars");
        }
        /// <summary>
        /// Adds a Dollar Coin when button clicked to drawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DollarCoin_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddCoin(Coins.Dollar, 1);
            AmountAdded += 1;
            InvokePropertyChanged("Dollars");
        }
        /// <summary>
        /// Adds a Dollar Bill when button clicked to drawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DollarBill_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddBill(Bills.One, 1);
            AmountAdded += 1;
            InvokePropertyChanged("Ones");
        }
        /// <summary>
        /// Adds a Two  when button clicked to drawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TwoBill_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddBill(Bills.Two, 1);
            AmountAdded += 2;
            InvokePropertyChanged("Twos");
        }
        /// <summary>
        /// Adds a Five when button clicked to drawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiveBill_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddBill(Bills.Five, 1);
            AmountAdded += 5;
            InvokePropertyChanged("Fives");
        }
        /// <summary>
        /// Adds a Ten when button clicked to drawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TenBill_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddBill(Bills.Ten, 1);
            AmountAdded += 10;
            InvokePropertyChanged("Tens");
        }
        /// <summary>
        /// Adds a Twenty when button clicked to drawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TwentyBill_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddBill(Bills.Twenty, 1);
            AmountAdded += 20;
            InvokePropertyChanged("Twenties");
        }
        /// <summary>
        /// Adds a Fifty when button clicked to drawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiftyBill_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddBill(Bills.Fifty, 1);
            AmountAdded += 50;
            InvokePropertyChanged("Fifties");
        }
        /// <summary>
        /// Adds a Hundred when button clicked to drawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HundredBill_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddBill(Bills.Hundred, 1);
            AmountAdded += 100;
            InvokePropertyChanged("Hundreds");
        }

        /// <summary>
        /// Helper method for triggering PropertyChanged events
        /// </summary>
        /// <param name="denomination"></param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountAdded"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalLeft"));

            if(TotalLeft < 0)
            {
                double amount = Math.Round(TotalValue, 2);
                GiveChange(amount);
            }


        }

        void GiveChange(double amount)
        {
            StringBuilder changegiven = new StringBuilder();
            while (amount < 0)
            {
                if (amount <= -100 && drawer.Hundreds > 0)
                {
                    drawer.RemoveBill(Bills.Hundred, 1);
                    amount += 100;
                    changegiven.Append("Hundred Bill \n");
                }
                else if (amount <= -50 && drawer.Fifties > 0)
                {
                    drawer.RemoveBill(Bills.Fifty, 1);
                    amount += 50;
                    changegiven.Append("Fifty Bill \n");
                }
                else if (amount <= -20 && drawer.Twenties > 0)
                {
                    drawer.RemoveBill(Bills.Twenty, 1);
                    amount += 20;
                    changegiven.Append("Twenty Bill \n");
                }
                else if (amount <= -10 && drawer.Tens > 0)
                {
                    drawer.RemoveBill(Bills.Ten, 1);
                    amount += 10;
                    changegiven.Append("Ten Bill \n");
                }
                else if (amount <= -5 && drawer.Fives > 0)
                {
                    drawer.RemoveBill(Bills.Five, 1);
                    amount += 5;
                    changegiven.Append("Five Bill \n");
                }
                else if (amount <= -1 && drawer.Ones > 0)
                {
                    drawer.RemoveBill(Bills.One, 1);
                    amount += 1;
                    changegiven.Append("Dollar Bill \n");
                }
                else if (amount <= -.5 && drawer.HalfDollars > 0)
                {
                    drawer.RemoveCoin(Coins.HalfDollar, 1);
                    amount += .50;
                    changegiven.Append("Half Dollar \n");
                }
                else if (amount <= -.25 && drawer.Quarters > 0)
                {
                    drawer.RemoveCoin(Coins.Quarter, 1);
                    amount += .25;
                    changegiven.Append("Quarter \n");
                }
                else if (amount <= -.1 && drawer.Dimes > 0)
                {
                    drawer.RemoveCoin(Coins.Dime, 1);
                    amount += .10;
                    changegiven.Append("Dime \n");
                }
                else if (amount <= -.05 && drawer.Nickels > 0)
                {
                    drawer.RemoveCoin(Coins.Nickel, 1);
                    amount += .05;
                    changegiven.Append("Nickel \n");
                }
                else if (amount <= -.01 && drawer.Pennies > 0)
                {
                    drawer.RemoveCoin(Coins.Penny, 1);
                    amount += .01;
                    changegiven.Append("Penny \n");
                }
                else if (TotalValue == 0)
                {
                    MessageBox.Show("Not Enough Change");
                }
            }

            string change = "";
            var tansaction = new TranscationControl();
            tansaction.ReciptString(change);
        }

    }
}
