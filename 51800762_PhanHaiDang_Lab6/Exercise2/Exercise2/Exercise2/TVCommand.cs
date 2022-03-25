using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class TVCommand : ICommand
    {
        public TV tv;
        public TVCommand(TV tv)
        {
            this.tv = tv;
        }
        public string getName()
        {
            return "TV";
        }

        public void off()
        {
            tv.off();
        }

        public void on()
        {
            tv.on();
        }
    }
}
