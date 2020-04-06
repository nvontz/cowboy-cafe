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
using CowboyCafe.Extensions;
using CowboyCafe.Data;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TranscationControl.xaml
    /// </summary>
    public partial class TranscationControl : UserControl
    {
   

        public TranscationControl()
        {
            InitializeComponent();
        }

        public double TotalPayment { get; set; }
        /// <summary>
        /// Method For Payment Using Cash
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CashPaymentButton_Clicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                var orderControl = this.FindAncestor<OrderControl>();    
                orderControl.SwapOrderScreen(new CashControl(order.total));
            }

        }
        /// <summary>
        /// Method for Payment using a Credit Card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreditPaymentButton_Clicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                CardTerminal terminal = new CardTerminal();
                ResultCode result = terminal.ProcessTransaction(order.total);
                if(result == ResultCode.Success)
                {
                    ReceiptPrinter printer = new ReceiptPrinter();
                    ReciptString("Credit");

                    DataContext = new Order();
                    var orderControl = this.FindAncestor<OrderControl>();
                    orderControl.SwapOrderScreen(new OrderControl());
                    
                }
                else
                {
                    MessageBox.Show(result.ToString());
                }

            }
           
        }
        /// <summary>
        /// Method that Cancels the Transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelTransactionButton_Clicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwapOrderScreen(new OrderControl());
        }
        /// <summary>
        /// Helper Method that prints the string
        /// </summary>
        /// <returns></returns>
        public void ReciptString(string ending)
        {
            StringBuilder sb = new StringBuilder();
            if(DataContext is Order order)
            {
               
                order.OrderNumber.ToString();
            }
        }
    }
}
