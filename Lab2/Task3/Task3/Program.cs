using System;
using System.Threading;
using Task3;

class Program
{
    static void Main(string[] args)
    {
        Thread t1 = new Thread(() =>
        {
            var auth1 = Authenticator.Instance;
            auth1.Authenticate("user1", "pass1");
        });

        Thread t2 = new Thread(() =>
        {
            var auth2 = Authenticator.Instance;
            auth2.Authenticate("user2", "pass2");
        });

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Both threads accessed the same Authenticator instance.");
    }
}
