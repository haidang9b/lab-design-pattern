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
            var simple = new DefaultLogger();
            IDecoratorLogger compress = new CompressLogger(simple);
            string message = "Test";
            compress.log(message);
            Console.WriteLine("----------");
            IDecoratorLogger encrypt = new EncryptLogger(simple);
            encrypt.log(message);
            Console.WriteLine("----------");
            encrypt = new EncryptLogger(compress);
            encrypt.log(message);
            Console.WriteLine("----------");

            encrypt = new EncryptLogger(simple);
            compress = new CompressLogger(encrypt);
            compress.log(message);
            Console.ReadKey();
        }
    }
}
