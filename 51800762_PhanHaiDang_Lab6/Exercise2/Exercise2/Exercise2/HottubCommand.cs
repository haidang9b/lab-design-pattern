using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class HottubCommand: ICommand
    {
        Hottub hottub;
        public HottubCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }

        public void off()
        {
            hottub.jetsOff() ;
        }

        public void on()
        {
            hottub.jetsOn() ;
        }
        public string getName()
        {
            return "Hottub";
        }
    }
}
