using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;
using Core.Common;

namespace AcmeCustomerManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            // populate the customer instance

            var order = new Order();
            // populate the order instance

            var allowSplitOrders = true;

            var emailReceipt = true;

            var payment = new Payment();
            // populate the payment info from the UI

            var orderController = new OrderController();
            orderController.PlaceOrder(customer, order, payment, allowSplitOrders, emailReceipt);
        }
    }
}
