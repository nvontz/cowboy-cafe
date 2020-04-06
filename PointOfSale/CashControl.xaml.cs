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
using CowboyCafe.Extensions;

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
        static CashDrawer drawer = new CashDrawer();
        /// <summary>
        /// Initializes the CashController
        /// </summary>
        public CashControl(Order order)
        {
            InitializeComponent();
            TotalDue = order.total;
            neworder = order;   
        }
        private Order neworder { get; set; }
        /// <summary>
        /// Keeps track of the amount the user inputed
        /// </summary>
        public double AmountAdded { get; set; }

        /// <summary>
        /// The amount the user owes
        /// </summary>
        public double TotalDue { get; set; }
        /// <summary>
        /// The amount of money the customer has left to pay
        /// </summary>
        public double TotalLeft
        {
            get { return TotalDue - AmountAdded; }
        }
        /// <summary>
        /// Sets the TotalValue to the drawer.TotalValue
        /// </summary>
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
                double amount = Math.Round(TotalLeft, 2);
                GiveChange(amount);
            }


        }

        void GiveChange(double amount)
        {
            StringBuilder changegiven = new StringBuilder();
            double change = Math.Round(Math.Abs(amount), 2);
            double changeprint = change;
            while (Math.Round(change, 2) != 0)
            {
                if (change >= 100 && drawer.Hundreds > 0)
                {
                    drawer.RemoveBill(Bills.Hundred, 1);
                    changegiven.Append("Hundred Bill \n");
                    change -= 100;
                }
                else if (change >= 50 && drawer.Fifties > 0)
                {
                    drawer.RemoveBill(Bills.Fifty, 1);
                    changegiven.Append("Fifty Bill \n");
                    change -= 50;
                }
                else if (change >= 20 && drawer.Twenties > 0)
                {
                    drawer.RemoveBill(Bills.Twenty, 1);
                    changegiven.Append("Twenty Bill \n");
                    change -= 20;
                }
                else if (change >= 10 && drawer.Tens > 0)
                {
                    drawer.RemoveBill(Bills.Ten, 1);
                    changegiven.Append("Ten Bill \n");
                    change -= 10;
                }
                else if (change >= 5 && drawer.Fives > 0)
                {
                    drawer.RemoveBill(Bills.Five, 1);
                    changegiven.Append("Five Bill \n");
                    change -= 5;
                }
                else if (change >= 1 && drawer.Ones > 0)
                {
                    drawer.RemoveBill(Bills.One, 1);
                    changegiven.Append("Dollar Bill \n");
                    change -= 1;
                }
                else if (change >= .5 && drawer.HalfDollars > 0)
                {
                    drawer.RemoveCoin(Coins.HalfDollar, 1);
                    changegiven.Append("Half Dollar \n");
                    change -= .50;
                }
                else if (change >= .25 && drawer.Quarters > 0)
                {
                    drawer.RemoveCoin(Coins.Quarter, 1);
                    changegiven.Append("Quarter \n");
                    change -= .25;
                }
                else if (change >= .1 && drawer.Dimes > 0)
                {
                    drawer.RemoveCoin(Coins.Dime, 1);
                    changegiven.Append("Dime \n");
                    change -= .10;
                }
                else if (change >= .05 && drawer.Nickels > 0)
                {
                    drawer.RemoveCoin(Coins.Nickel, 1);
                    changegiven.Append("Nickel \n");
                    change -= .05;
                }
                else if (change >= .01 && drawer.Pennies > 0)
                {
                    drawer.RemoveCoin(Coins.Penny, 1);
                    changegiven.Append("Penny \n");
                    change -= .01;
                }
                else if (drawer.Pennies == 0)
                {
                    MessageBox.Show("Not Enough Change Adding a new registers worth");
                    drawer = new CashDrawer();
                }
                else if (change < 0.00)
                {
                    break;
                }
            }

            ReceiptPrinter printer = new ReceiptPrinter();

            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            sb.Append("\nOrder Number " + neworder.OrderNumber.ToString());
            string date = DateTime.Now.ToString();
            sb.Append("\n" + date);
            foreach (IOrderItem item in neworder.Items)
            {
                sb.Append("\n" + item.ToString() + "   ");
                sb.Append(item.Price.ToString("C2"));
                foreach (string instruct in item.SpecialInstructions)
                {
                    sb.Append("\n" + instruct.ToString());
                }
            }
            sb.Append("\nSubtotal " + neworder.Subtotal.ToString("C2"));
            sb.Append("\nTotal With Tax " + neworder.total.ToString("C2"));
            sb.Append("\nAmount Paid " + AmountAdded.ToString("C2"));
            sb.Append("\nChange Returned " + changeprint.ToString("C2"));

            printer.Print(sb.ToString());


            DataContext = new Order();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwapOrderScreen(new OrderControl());

        }
    }
}
