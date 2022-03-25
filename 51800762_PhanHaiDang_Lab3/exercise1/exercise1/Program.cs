using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new Coffee();
            CaffeineBeverage tea = new Tea();
            
            Console.WriteLine("Make tea");
            tea.prepareRecipe();

            Console.WriteLine("-----------------------");
            Console.WriteLine("Make coffee");
            coffee.prepareRecipe();
            Console.ReadLine();

        }
    }
}
