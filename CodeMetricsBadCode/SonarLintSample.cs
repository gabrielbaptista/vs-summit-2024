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
            catch
            {

            }
            return result;
        }
    }
}
