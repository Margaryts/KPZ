using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task1
{
    class PremiumSubscription : Subscription
    {
        public override string Name => "Преміум";
        public override decimal MonthlyFee => 100.00m;
        public override int MinPeriod => 24;
        public override List<string> Channels => new List<string> { "HD Фільми", "Спорт HD", "Ексклюзивні шоу" };
    }
}
