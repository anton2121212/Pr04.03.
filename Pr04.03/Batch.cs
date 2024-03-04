using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04._03
{
     class Batch:Product
    {
        public int Quantity { get; set; }

        public override void Info()
        {
            Console.WriteLine($"Batch: {Name}, Price: {Price}, Quantity: {Quantity}, Production Date: {ProductionDate}, Expiry Date: {ExpiryDate}");
        }
    }
}
