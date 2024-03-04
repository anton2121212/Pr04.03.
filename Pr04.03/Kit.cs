using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pr04._03
{
    class Kit:Product
    {
        public List<Product> Products { get; set; }

        public override void Info()
        {
            Console.WriteLine($"Kit: {Name}, Price: {Price}");
            Console.WriteLine("Products in the kit:");
            foreach (var product in Products)
            {
                product.Info();
            }
        }
    }
}
