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

        /// <summary>
        /// Calculates the percent of the step goal reached.
        /// </summary>
        /// <param name="goalSteps"></param>
        /// <param name="actualSteps"></param>
        /// <returns></returns>
        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            if (string.IsNullOrWhiteSpace(goalSteps))
                throw new ArgumentException("Goal must be entered", nameof(goalSteps));

            if (string.IsNullOrWhiteSpace(actualSteps))
                throw new ArgumentException("Actual steps count must be entered", nameof(actualSteps));

            if (!decimal.TryParse(goalSteps, out var goalStepCount))
                throw new ArgumentException("Goal must be numeric", nameof(goalSteps));

            if (!decimal.TryParse(goalSteps, out var actualStepsCount))
                throw new ArgumentException("Actual steps must be numeric", nameof(actualSteps));

            if (goalStepCount <= 0)
                throw new ArgumentException("Goal must be greater than 0", nameof(goalSteps));

            return (Convert.ToDecimal(actualStepsCount) / Convert.ToDecimal(goalSteps)) * 100;
        }
    }
}
