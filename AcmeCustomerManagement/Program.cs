using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // -- If this is a new customer, create the customer record --
            // Determine whether the customer is an existing customer.
            // If not, validate entered customer information
            // If not valid, notify the user.
            // Open a connection
            // Set stored procedure parameter with the customer data.
            // call the save stored procedure.

            // -- Create the order for the customer --
            // For each item ordered,
            // Validate the entered information.
            // If not valid, notify the user.
            // If valid,
            // Open a connection
            // Set stored procedure parameter with the order data.
            // Call the save stored procedure.

            // -- Send an email receipt --
            // If the user requested a receipt
            // Get the customer data
            // Ensure a valid email address is provided.
            // If not,
            // request an email address for the user.
            // Open a connection
            // Set stored procedure parameters with the customer data.
            // Call the save stored procedure.
            // If a valid email address is provided,
            // Send an email.

            // -- Order the items from inventory --
            // For each item ordered,
            // Locate the item in inventory.
            // If no longer available, notify the user.
            // If any items are back ordered and the customer does not
            // want to split orders,
            // notify the user.
            // If the item is available,
            // Decrement the quantity remaining.
            // Open a connection
            // Set a stored procedure parameter with the inventory data.
            // Call the save stored procedure.

            // -- Process the payment --
            // If credit card,
            // process the credit card payment.
            // If paypal,
            // process the paypal payment.
            // If there is a payment problem, notity the user.
            // Open a connection
            // Set stored procedure parameter with the payment data.
            // Call the save stored procedure.
        }
    }
}
