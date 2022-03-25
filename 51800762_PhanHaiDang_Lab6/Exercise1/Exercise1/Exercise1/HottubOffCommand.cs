using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class HottubOffCommand : ICommand
    {
        Hottub hottub;
        public HottubOffCommand( Hottub hottub)
        {
            this.hottub = hottub;
        }
        public void execute()
        {
            hottub.jetsOff();
        }
        public void undo()
        {
            hottub.jetsOn();
        }

    }
}
