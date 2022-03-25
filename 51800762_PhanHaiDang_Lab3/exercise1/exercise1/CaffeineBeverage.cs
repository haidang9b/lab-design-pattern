using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public abstract class CaffeineBeverage
    {
        public  void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            if (customerWantsCondiments())
            {
                addCondiments();
            }
        }



        public void boilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        public abstract void brew();
        public abstract void addCondiments();
        public virtual bool customerWantsCondiments()
        {
            return true;
        }
    }
}
