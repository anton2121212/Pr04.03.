using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04._03
{
    class SinProduct :Product
    {
        public override void Info()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}, Production Date: {ProductionDate}, Expiry Date: {ExpiryDate}");
        }
    }
}
