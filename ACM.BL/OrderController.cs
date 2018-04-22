using Core.Common;

namespace ACM.BL
{
    /// Check that this method agains the characteristic of a clean,
    /// testable and predictable method:
    /// 
    /// Does it have a clear purpose? Yes, its purpose is to place an order
    /// Does it have a good name? Yes
    /// Is all of its code focused on the goal? Yes, all of this code is required
    /// in order to meet the requirements of placing an order.
    /// Does it have a reasonable size? Yes, it fits nicely in the screen.
    /// Can be tested? Yes, this method is now in a class library.
    /// Does it have a predictable result? Well, this method does not return a result
    /// nor does it have any error or exception handling. (@todo)
    public class OrderController
    {
        private CustomerRepository CustomerRepository { get; }

        private OrderRepository OrderRepository { get; }

        private InventoryRepository InventoryRepository { get; }

        private EmailLibrary EmailLibrary { get; }

        public OrderController()
        {
            CustomerRepository = new CustomerRepository();
            OrderRepository = new OrderRepository();
            InventoryRepository = new InventoryRepository();
            EmailLibrary = new EmailLibrary();
        }

        // flags usually go at the end
        public void PlaceOrder(Customer customer,
                                Order order,
                                Payment payment,
                                bool allowSplitOrders,
                                bool emailReceipt)
        {
            CustomerRepository.Add(customer);
            
            OrderRepository.Add(order);
            
            InventoryRepository.OrderItems(order, allowSplitOrders);

            payment.ProcessPayment();

            if (emailReceipt)
            {
                customer.ValidateEmail();
                CustomerRepository.Update();
                
                EmailLibrary.SendEmail(customer.EmailAddress, "Here is your receipt");
            }
        }
    }
}
