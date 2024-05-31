using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMetricsBadCode
{
    internal class CyclomaticComplexitySample
    {
        
        public void Execute(string billingMode, string creditCardMethod)
        {
            /*
            This code is being used just for explaining the concept of cyclomatic complexity. 
            It makes no sense at all. Please Calculate Code Metrics for understanding 
            */
            switch (creditCardMethod)
            {
                case "A":
                    if (billingMode == "M1")
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                            $"Message Response {creditCardMethod}");
                    else
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                            $"Message Response {creditCardMethod}");
                    break;
                case "B":
                    if (billingMode == "M2")
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                            $"Message Response {creditCardMethod}");
                    else
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                            $"Message Response {creditCardMethod}");
                    break;
                case "C":
                    if (billingMode == "M3")
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                            $"Message Response {creditCardMethod}");
                    else
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                            $"Message Response {creditCardMethod}");
                    break;
                case "D":
                    if (billingMode == "M4")
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                            $"Message Response {creditCardMethod}");
                    else
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                            $"Message Response {creditCardMethod}");
                    break;
                case "E":
                    if (billingMode == "M5")
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                            $"Message Response {creditCardMethod}");
                    else
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                            $"Message Response {creditCardMethod}");
                    break;
                case "F":
                    if (billingMode == "M6")
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                            $"Message Response {creditCardMethod}");
                    else
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                            $"Message Response {creditCardMethod}");
                    break;
                case "G":
                    if (billingMode == "M7")
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                            $"Message Response {creditCardMethod}");
                    else
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                            $"Message Response {creditCardMethod}");
                    break;
                case "H":
                    if (billingMode == "M8")
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                            $"Message Response {creditCardMethod}");
                    else
                        Console.WriteLine($"Billing Mode {billingMode} for " +
                            $"Message Response {creditCardMethod}");
                    break;
                default:
                    Console.WriteLine("The result of processing is unknown");
                    break;
            }

        }
    }
}
