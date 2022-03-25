using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class LightOffCommand: ICommand
    {
        Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.off();
        }
        public void undo()
        {
            light.on();
        }
    }
}
