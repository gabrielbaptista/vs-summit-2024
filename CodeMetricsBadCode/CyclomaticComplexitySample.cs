using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMetricsBadCode
{
    internal class CyclomaticComplexitySample
    {
        private Dictionary<string, Action<string>> creditCardActions;

        /// <summary>
        /// Initializes a new instance of the <see cref="CyclomaticComplexitySample"/> class.
        /// </summary>
        public CyclomaticComplexitySample()
        {
            creditCardActions = new Dictionary<string, Action<string>>()
                {
                    { "A", (billingMode) => Console.WriteLine($"Billing Mode {billingMode} for Message Response A") },
                    { "B", (billingMode) => Console.WriteLine($"Billing Mode {billingMode} for Message Response B") },
                    { "C", (billingMode) => Console.WriteLine($"Billing Mode {billingMode} for Message Response C") },
                    { "D", (billingMode) => Console.WriteLine($"Billing Mode {billingMode} for Message Response D") },
                    { "E", (billingMode) => Console.WriteLine($"Billing Mode {billingMode} for Message Response E") },
                    { "F", (billingMode) => Console.WriteLine($"Billing Mode {billingMode} for Message Response F") },
                    { "G", (billingMode) => Console.WriteLine($"Billing Mode {billingMode} for Message Response G") },
                    { "H", (billingMode) => Console.WriteLine($"Billing Mode {billingMode} for Message Response H") }
                };
        }

        /// <summary>
        /// Executes the specified billing mode and credit card method.
        /// </summary>
        /// <param name="billingMode">The billing mode.</param>
        /// <param name="creditCardMethod">The credit card method.</param>
        public void Execute(string billingMode, string creditCardMethod)
        {
            /*
            This code is being used just for explaining the concept of cyclomatic complexity. 
            It makes no sense at all. Please Calculate Code Metrics for understanding 
            */
            if (creditCardActions.ContainsKey(creditCardMethod))
            {
                creditCardActions[creditCardMethod].Invoke(billingMode);
            }
            else
            {
                Console.WriteLine("The result of processing is unknown");
            }
        }
    }
}
