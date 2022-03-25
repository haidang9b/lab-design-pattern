using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public class Tea : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void brew()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}
