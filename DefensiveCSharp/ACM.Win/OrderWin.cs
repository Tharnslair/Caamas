using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACM.BL;


namespace ACM.Win
{
    public partial class OrderWin : Form
    {

        public OrderWin()
        {
            InitializeComponent();
        }

        private void lblPlaceOrder_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        private void PlaceOrder()
        {
            var allowSplitOrders = true;
            var emailReceipt = true;

            var customer = new Customer();
            // Populate the customer instance

            var order = new Order();
            // Populate the order instance

            var payment = new Payment();
            // Populate the payment info from the UI

            var orderController = new OrderController();
            orderController.PlaceOrder(customer, order, payment,
                allowSplitOrders: false, emailReceipt: true); // allowSplitOrders: false, emailReceipt: true
        }

    }
}
