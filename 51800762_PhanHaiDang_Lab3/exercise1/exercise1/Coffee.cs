using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public class Coffee : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        public override void brew()
        {
            Console.WriteLine("Adding sugar and milk");
        }
        public override bool customerWantsCondiments()
        {
            
            string answer = getInputUser();
            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string getInputUser()
        {
            Console.Write("Would you like milk and sugar with your coffee (y/n)?");
            string answer = Console.ReadLine();
            if(answer == null)
            {
                return "n";
            }
            return answer;
        }
    }
}
