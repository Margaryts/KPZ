using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class SmartTextReader : ISmartTextReader
    {
        public char[][] ReadText(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            List<char[]> result = new List<char[]>();

            foreach (string line in lines)
            {
                result.Add(line.ToCharArray());
            }

            return result.ToArray();
        }
    }
}
