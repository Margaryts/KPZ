using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    
        public class IPhoneLaptop : ILaptop
        {
            public void ShowSpecs() => Console.WriteLine("IPhone Laptop: 16GB RAM, AMD CPU,IOS");
        }

        public class IPhoneNetbook : INetbook
        {
            public void ShowSpecs() => Console.WriteLine("IPhone Netbook: 256GB RAM, Compact");
        }

        public class IPhoneEBook : IEBook
        {
            public void ShowSpecs() => Console.WriteLine("IPhone EBook: E-IOS, WiFi");
        }

        public class IPhoneSmartphone : ISmartphone
        {
            public void ShowSpecs() => Console.WriteLine("IPhone Smartphone: AMOLED screen, IOS");
       }
    
}
