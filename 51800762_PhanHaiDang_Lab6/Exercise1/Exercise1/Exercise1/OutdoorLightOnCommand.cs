using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class OutdoorLightOnCommand: ICommand
    {
        OutdoorLight outdoorLight;
        public OutdoorLightOnCommand(OutdoorLight outdoorLight)
        {
            this.outdoorLight = outdoorLight;
        }

        public void execute()
        {
            outdoorLight.on();
        }
        public void undo()
        {
            outdoorLight.off();
        }
    }
}
