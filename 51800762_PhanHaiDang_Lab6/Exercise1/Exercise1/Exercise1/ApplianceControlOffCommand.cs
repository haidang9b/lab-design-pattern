using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class ApplianceControlOffCommand : ICommand
    {
        ApplianceControl applianceControl;
        public ApplianceControlOffCommand(ApplianceControl applianceControl)
        {
            this.applianceControl = applianceControl;
        }
        public void execute()
        {
            applianceControl.off();
        }

        public void undo()
        {
            applianceControl.on();
        }
    }
}
