using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class TVOnCommand: ICommand
    {
        TV tv;
        public TVOnCommand(TV tv)
        {
            this.tv = tv;
        }
        public void execute()
        {
            tv.on();
        }

        public void undo()
        {
            tv.off();
        }
    }
}
