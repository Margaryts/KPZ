using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Money
    {
        public int WholePart { get; private set; }
        public int Cents { get; private set; }
        public string Currency { get; private set; }

        public Money(int whole, int cents, string currency)
        {
            WholePart = whole;
            Cents = cents;
            Currency = currency;
        }

        public void Display()
        {
            Console.WriteLine($"{WholePart}.{Cents:00} {Currency}");
        }
    }
}
