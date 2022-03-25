using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class LightCommand : ICommand
    {
        Light light;
        public LightCommand(Light light)
        {
            this.light = light;
        }
        public void off()
        {
            light.off();
        }

        public void on()
        {
            light.on();
        }
        public string getName()
        {
            return "Light";
        }
    }
}
