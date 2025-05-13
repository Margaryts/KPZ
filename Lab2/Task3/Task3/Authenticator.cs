using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public sealed class Authenticator
    {
        private static readonly Lazy<Authenticator> instance =
        new Lazy<Authenticator>(() => new Authenticator());

        private Authenticator()
        {
            Console.WriteLine("Authenticator created.");
        }

        public static Authenticator Instance => instance.Value;

        public void Authenticate(string username, string password)
        {
            Console.WriteLine($"Authenticating {username}...");
        }
    }
}
