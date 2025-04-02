using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Reporting
    {
        private Warehouse warehouse;

        public Reporting(Warehouse warehouse)
        {
            this.warehouse = warehouse;
        }

        public void InventoryReport()
        {
            Console.WriteLine("Звіт по залишках на складі:");
            warehouse.ShowInventory();
        }
    }
}
