using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class OutdoorLightCommand : ICommand
    {
        OutdoorLight outdoorLight;
        public OutdoorLightCommand(OutdoorLight outdoorLight)
        {
            this.outdoorLight = outdoorLight;
        }
        public string getName()
        {
            return "Outdoor light";
        }

        public void off()
        {
            outdoorLight.off();
        }

        public void on()
        {
            outdoorLight.on();
        }
    }
}
