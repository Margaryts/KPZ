using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DomesticSubscription : Subscription
    {
        public override string Name => "Домашня";
        public override decimal MonthlyFee => 9.99m;
        public override int MinPeriod => 6;
        public override List<string> Channels => new List<string> { "Новини", "Фільми", "Спорт" };
    }
}
