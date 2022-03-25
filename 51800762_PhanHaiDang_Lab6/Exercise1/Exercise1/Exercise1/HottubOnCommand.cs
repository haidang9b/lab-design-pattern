using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class HottubOnCommand : ICommand
    {
        Hottub hottub;
        public HottubOnCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }
        public void execute()
        {
            hottub.jetsOn();
        }
        public void undo()
        {
            hottub.jetsOff();
        }
    }
}
