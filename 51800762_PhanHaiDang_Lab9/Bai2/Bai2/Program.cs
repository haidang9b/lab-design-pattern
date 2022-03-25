using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new WatcherService(@"D:\Java\Design Pattern\testlab9");
            IObserver observer1 = new Client();
            IObserver observer2 = new Client();

            service.AddObserver(observer1);

            service.AddObserver(observer2);
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();

        }
    }
}
