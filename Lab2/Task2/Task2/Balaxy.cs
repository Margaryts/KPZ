using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BalaxyLaptop : ILaptop
    {
        public void ShowSpecs() => Console.WriteLine("Balaxy Laptop: 16GB RAM, AMD CPU");
    }

    public class BalaxyNetbook : INetbook
    {
        public void ShowSpecs() => Console.WriteLine("Balaxy Netbook: 8GB RAM, Compact");
    }

    public class BalaxyEBook : IEBook
    {
        public void ShowSpecs() => Console.WriteLine("Balaxy EBook: E-Ink, WiFi");
    }

    public class BalaxySmartphone : ISmartphone
    {
        public void ShowSpecs() => Console.WriteLine("Balaxy Smartphone: AMOLED screen, Android OS");
    }
}
