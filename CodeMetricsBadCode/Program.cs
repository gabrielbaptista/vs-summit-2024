using CodeMetricsBadCode.SampleClasses;
using System;
using System.IO;
using System.Text;

namespace CodeMetricsBadCode
{
    
    class Program
    {
        static void Main()
        {
            var memoryLeakSample = new MemoryLeakSample();
            memoryLeakSample.Execute();

            var cyclomaticComplexitySample = new CyclomaticComplexitySample();
            cyclomaticComplexitySample.Execute(GetBillingMode(),ProcessCreditCardMethod());
        }


        /// <summary>
        /// This is just an example about how to answer the "billing mode" 
        /// </summary>
        /// <returns>A result for simulating the billing mode</returns>
        private static string GetBillingMode()
        {
            return "M1";
        }

        /// <summary>
        /// This is just an example about how to answer the "credit card processing" 
        /// </summary>
        /// <returns>A result for simulating the processing method</returns>
        private static string ProcessCreditCardMethod()
        {
            return "S";
        }
    }
}
