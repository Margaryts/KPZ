using Task2;

class Program
{
    static void Main(string[] args)
    {
        IDeviceFactory factoryBalaxy = new BalaxyFactory();
        IDeviceFactory factoryIPhone = new IPhoneFactory();
        IDeviceFactory factoryKioami = new KioamiFactory();

        var laptopB = factoryBalaxy.CreateLaptop();
        var netbookB = factoryBalaxy.CreateNetbook();
        var ebookB = factoryBalaxy.CreateEBook();
        var smartphoneB = factoryBalaxy.CreateSmartphone();
        var laptopIP = factoryIPhone.CreateLaptop();
        var netbookIP = factoryIPhone.CreateNetbook();
        var ebookIP = factoryIPhone.CreateEBook();
        var smartphoneIP = factoryIPhone.CreateSmartphone();
        var laptopK = factoryKioami.CreateLaptop();
        var netbookK = factoryKioami.CreateNetbook();
        var ebookK = factoryKioami.CreateEBook();
        var smartphoneK = factoryKioami.CreateSmartphone();

        Console.WriteLine("=== Balaxy Devices ===");
        laptopB.ShowSpecs();
        netbookB.ShowSpecs();
        ebookB.ShowSpecs();
        smartphoneB.ShowSpecs();
        Console.WriteLine("=== IPhone Devices ===");
        laptopIP.ShowSpecs();
        netbookIP.ShowSpecs();
        ebookIP.ShowSpecs();
        smartphoneIP.ShowSpecs();
        Console.WriteLine("=== Kioami Devices ===");
        laptopK.ShowSpecs();
        netbookK.ShowSpecs();
        ebookK.ShowSpecs();
        smartphoneK.ShowSpecs();
    }
}
