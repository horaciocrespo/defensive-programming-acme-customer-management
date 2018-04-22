using System;
using Core.Common;

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

        // option 1: Return a value -> bool
        // option 2: Return void and throw exceptions. Note that we're throwing ArgumenExceptions
        // despite the fact that this method does not receive arguments, this indicates
        // that exceptions are not really meant to handle validation, they are meant
        // to handle exceptional conditions and failure reporting.
        // option 3: Returning a boolean and receive a message parameter as ref.
        // option 4: Return a tuple.
        // option 5: Return a new object. This is better than the previous ones.
        public OperationResult ValidateEmail()
        {
            var operationResult = new OperationResult();

            if (string.IsNullOrWhiteSpace(this.EmailAddress))
            {
                operationResult.Success = false;
                operationResult.AddMessage("Email Address is null");
            }

            if (operationResult.Success)
            {
                var isValidFormat = true;

                // code here that validates the format of the email
                // using a regular expression.
                if (!isValidFormat)
                {
                    operationResult.Success = false;
                    operationResult.AddMessage("Email address is not in a correct format");
                }
            }

            if (operationResult.Success)
            {
                var isRealDomain = true;

                // code here that confirms whether the domain exists.
                if (!isRealDomain)
                {
                    operationResult.Success = false;
                    operationResult.AddMessage("Email address does not include a valid domain");
                }
            }

            return operationResult;
        }

        /// <summary>
        /// Calculates the percent of the step goal reached.
        /// Using the defensive programming fail fast method. Now our method is easier
        /// to test because we now each of the conditions that we need to test, however
        /// is important to note that this method has gone from one line of code
        /// to eleven lines of code. That's why sometimes defensive coding is considered
        /// a code smell because it increases the lines of code. (@todo refactor code smell)
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
                throw new ArgumentException("Goal must be numeric");

            if (!decimal.TryParse(actualSteps, out var actualStepCount))
                throw new ArgumentException("Actual steps must be numeric");

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0)
                throw new ArgumentException("Goal must be greater than 0", "goalSteps");

            return (actualStepCount / goalStepCount) * 100;
        }
    }
}
