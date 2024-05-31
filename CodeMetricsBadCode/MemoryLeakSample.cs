using System;
using System.IO;
using System.Text;

namespace CodeMetricsBadCode
{
    internal class MemoryLeakSample
    {
        public MemoryLeakSample()
        {
        }

        internal void Execute()
        {
            LoadData();
        }


        private static void LoadData()
        {
            using (FileStream file = new("C:\\file.txt", FileMode.CreateNew))
            {
                byte[] data = GetFileData();
                file.Write(data, 0, data.Length);
            }
        }

        private static byte[] GetFileData()
        {
            var text = "Sample text";
            return Encoding.GetEncoding("UTF-8").GetBytes(text);
        }
    }
}