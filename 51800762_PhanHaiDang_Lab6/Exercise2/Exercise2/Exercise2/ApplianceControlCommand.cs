using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class ApplianceControlCommand : ICommand
    {
        ApplianceControl applianceControl;
        public ApplianceControlCommand(ApplianceControl applianceControl)
        {
            this.applianceControl = applianceControl;
        }
        public string getName()
        {
            return "Appliance Control";
        }

        public void off()
        {
            applianceControl.off();
        }

        public void on()
        {
            applianceControl.on();
        }
    }
}
