using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class IPhoneFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop() => new IPhoneLaptop();
        public INetbook CreateNetbook() => new IPhoneNetbook();
        public IEBook CreateEBook() => new IPhoneEBook();
        public ISmartphone CreateSmartphone() => new IPhoneSmartphone();
    }
}
