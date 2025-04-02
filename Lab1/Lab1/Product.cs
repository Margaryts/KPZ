using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Product
    {
        public string Name { get; private set; }
        public Money Price { get; private set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        public void ApplyDiscount(int amount)
        {
            int totalCents = (Price.WholePart * 100 + Price.Cents) - amount;
            Price = new Money(totalCents / 100, totalCents % 100, Price.Currency);
        }
        public void Display()
        {
            Console.WriteLine($"{Name} - {Price.WholePart}.{Price.Cents:00} {Price.Currency}");
        }
    }
}
