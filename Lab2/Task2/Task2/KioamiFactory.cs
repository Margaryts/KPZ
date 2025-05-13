using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class KioamiFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop() => new KioamiLaptop();
        public INetbook CreateNetbook() => new KioamiNetbook();
        public IEBook CreateEBook() => new KioamiEBook();
        public ISmartphone CreateSmartphone() => new KioamiSmartphone();

}
}
