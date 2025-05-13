using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MobileAppFactory : SubscriptionCreator
    {
        public override Subscription CreateSubscription() => new EducationalSubscription();
    }
}
