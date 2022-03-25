using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class ApplianceControlOnCommand: ICommand
    {
        ApplianceControl applianceControl;
        public ApplianceControlOnCommand(ApplianceControl applianceControl)
        {
            this.applianceControl = applianceControl;
        }
        public void execute()
        {
            applianceControl.on();
        }

        public void undo()
        {
            applianceControl.off();
        }
    }
}
