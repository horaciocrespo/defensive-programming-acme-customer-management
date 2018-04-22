namespace ACM.BL
{
    public class CustomerRepository
    {
        public void Add(Customer customer)
        {
            // -- If this is a new customer, create the customer record --
            // Determine whether the customer is an existing customer.
            // If not, validate entered customer information
            // If not valid, notify the user.
            // Open a connection
            // Set stored procedure parameter with the customer data.
            // call the save stored procedure.
        }

        public void Update()
        {
            // Open a connection
            // Set stored procedure parameters with the customer data.
            // Call the save stored procedure.
        }
    }
}