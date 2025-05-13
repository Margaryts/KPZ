using System.Text;
using Task1;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        SubscriptionCreator webFactory = new WebSiteFactory();
        SubscriptionCreator appFactory = new MobileAppFactory();
        SubscriptionCreator callFactory = new ManagerCallFactory();

        Subscription webSubscription = webFactory.CreateSubscription();
        Subscription appSubscription = appFactory.CreateSubscription();
        Subscription callSubscription = callFactory.CreateSubscription();

        webSubscription.ShowInfo();
        appSubscription.ShowInfo();
        callSubscription.ShowInfo();
        Console.ReadKey();
    }
}