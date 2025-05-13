using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    public class SmartTextReaderLocker : ISmartTextReader
    {
        private readonly ISmartTextReader _reader;
        private readonly Regex _restrictedPattern;

        public SmartTextReaderLocker(ISmartTextReader reader, string restrictedRegex)
        {
            _reader = reader;
            _restrictedPattern = new Regex(restrictedRegex, RegexOptions.IgnoreCase);
        }

        public char[][] ReadText(string filePath)
        {
            if (_restrictedPattern.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return new char[0][];
            }

            return _reader.ReadText(filePath);
        }
    }
}
