using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyApp myApp = new MyApp();
            Console.WriteLine("--- Using Adapter --- ");
            ISimpleFTP ComplexFTP = new FTPAdapter();
            myApp.setFTP(ComplexFTP);
            myApp.doSomething();
            Console.WriteLine("--- Using Simple --- ");
            ISimpleFTP simple = new MyFTP();
            myApp.setFTP(simple);
            myApp.doSomething();
            Console.ReadKey();
        }
    }
}
