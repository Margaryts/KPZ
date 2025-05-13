using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task1
{
    class EducationalSubscription : Subscription
    {
        public override string Name => "Освітня";
        public override decimal MonthlyFee => 4.99m;
        public override int MinPeriod => 12;
        public override List<string> Channels => new List<string> { "Наука", "Документальні", "Історія" };
    }
}
