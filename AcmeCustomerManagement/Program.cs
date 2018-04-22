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

            var customerRepository = new CustomerRepository();
            customerRepository.Add(customer);

            var order = new Order();
            // populate the order instance

            var allowSplitOrders = true;

            var emailReceipt = true;

            var payment = new Payment();
            // populate the payment info from the UI

            var orderRepository = new OrderRepository();
            orderRepository.Add(order);

            var inventoryRepository = new InventoryRepository();
            inventoryRepository.OrderItems(order, allowSplitOrders);

            payment.ProcessPayment();

            if (emailReceipt)
            {
                customer.ValidateEmail();
                customerRepository.Update();

                var emailLibrary = new EmailLibrary();
                emailLibrary.SendEmail(customer.EmailAddress, "Here is your receipt");
            }
        }
    }
}
