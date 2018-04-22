using Core.Common;

namespace ACM.BL
{
    public class OrderController
    {
        // flags usually go at the end
        public void PlaceOrder(Customer customer,
                                Order order,
                                Payment payment,
                                bool allowSplitOrders,
                                bool emailReceipt)
        {
            var customerRepository = new CustomerRepository();
            customerRepository.Add(customer);

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
