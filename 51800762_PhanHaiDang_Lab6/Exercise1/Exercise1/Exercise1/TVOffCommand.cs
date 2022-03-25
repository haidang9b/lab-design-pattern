using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class TVOffCommand : ICommand
    {
        TV tv;
        public TVOffCommand(TV tv)
        {
            this.tv = tv;
        }
        public void execute()
        {
            tv.off();
        }
        public void undo()
        {
            tv.on();
        }
    }
}
