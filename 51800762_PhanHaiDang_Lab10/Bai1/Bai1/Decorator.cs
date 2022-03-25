
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public abstract class Logger
    {
       /* public string message;*/
        public abstract void log(string message);
    }

    public class DefaultLogger : Logger
    {
        public override void log(string message)
        {
            Console.WriteLine("Run Default Logger ");
            Console.WriteLine(message);
        }
    }

    public abstract class IDecoratorLogger: Logger
    {
        protected Logger wrapObj { get; set; }
        public IDecoratorLogger(Logger logger)
        {
            this.wrapObj = logger;
        }
        
    }

    public class EncryptLogger : IDecoratorLogger
    {
        public EncryptLogger(Logger wrapObj) : base(wrapObj)
        {

        }
        public override void log(string message)
        {
            Console.WriteLine("Run Encrypt Logger ");
            wrapObj.log(message);
        }
    }

    public class CompressLogger : IDecoratorLogger
    {
        public CompressLogger(Logger wrapObj) : base(wrapObj)
        {

        }
        public override void log(string message)
        {
            Console.WriteLine("Run Compress Logger ");
            wrapObj.log(message);
        }
    }
}
