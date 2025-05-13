using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class KioamiLaptop : ILaptop
    {
        public void ShowSpecs() => Console.WriteLine("Kioami Laptop: 64GB RAM, AMD CPU");
    }

    public class KioamiNetbook : INetbook
    {
        public void ShowSpecs() => Console.WriteLine("Kioami Netbook: 16GB RAM, Compact");
    }

    public class KioamiEBook : IEBook
    {
        public void ShowSpecs() => Console.WriteLine("Kioami EBook: E-Book, WiFi");
    }

    public class KioamiSmartphone : ISmartphone
    {
        public void ShowSpecs() => Console.WriteLine("Kioami Smartphone: AMOLED screen, Android OS");
    }
}
