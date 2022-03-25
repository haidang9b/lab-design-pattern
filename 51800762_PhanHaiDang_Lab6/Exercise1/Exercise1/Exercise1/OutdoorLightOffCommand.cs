using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class OutdoorLightOffCommand : ICommand
    {
        OutdoorLight outdoorLight;
        public OutdoorLightOffCommand(OutdoorLight outdoorLight)
        {
            this.outdoorLight = outdoorLight;
        }

        public void execute()
        {
            outdoorLight.off();
        }
        public void undo()
        {
            outdoorLight.on();
        }
    }
}
