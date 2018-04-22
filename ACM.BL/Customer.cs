using System;

namespace ACM.BL
{
    /// <summary>
    /// Manages a single customer.
    /// </summary>
    public class Customer
    {
        public int CustomerId { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void ValidateEmail()
        {
            // -- Send an email receipt --
            // If the user requested a receipt
            // Get the customer data
            // Ensure a valid email address is provided.
            // If not,
            // request an email address for the user.
        }

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            return (Convert.ToDecimal(actualSteps) / Convert.ToDecimal(goalSteps)) * 100;
        }
    }
}
