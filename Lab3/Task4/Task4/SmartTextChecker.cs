using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class SmartTextChecker : ISmartTextReader
    {
        private readonly ISmartTextReader _reader;

        public SmartTextChecker(ISmartTextReader reader)
        {
            _reader = reader;
        }

        public char[][] ReadText(string filePath)
        {
            Console.WriteLine($"[INFO] Opening file: {filePath}");

            try
            {
                char[][] result = _reader.ReadText(filePath);
                Console.WriteLine($"[INFO] File read successfully.");
                Console.WriteLine($"[INFO] Lines: {result.Length}");
                int totalChars = 0;
                foreach (var line in result)
                    totalChars += line.Length;

                Console.WriteLine($"[INFO] Total characters: {totalChars}");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Failed to read file: {ex.Message}");
                return new char[0][];
            }
            finally
            {
                Console.WriteLine($"[INFO] File closed.");
            }
        }
    }
}
