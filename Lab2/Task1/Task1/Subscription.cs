using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Subscription
    {
        public abstract string Name { get; }
        public abstract decimal MonthlyFee { get; }
        public abstract int MinPeriod { get; }
        public abstract List<string> Channels { get; }

        public void ShowInfo()
        {
            Console.WriteLine($"Підписка: {Name}");
            Console.WriteLine($"Щомісячна плата: {MonthlyFee} грн");
            Console.WriteLine($"Мінімальний період: {MinPeriod} місяців");
            Console.WriteLine("Канали:");
            Channels.ForEach(channel => Console.WriteLine($" - {channel}"));
            Console.WriteLine();
        }
    }
}
