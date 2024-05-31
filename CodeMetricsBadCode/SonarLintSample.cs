using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMetricsBadCode
{

    internal class SonarLintSample
    {
        public int? GetInt(string code)
        {
            int? result = null;
            try
            {
                result = Convert.ToInt32(code);
            }
            catch (Exception ex)
            {
                // Handle the exception or explain in a comment why it can be ignored.
                // Log the exception or perform any necessary error handling here
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
