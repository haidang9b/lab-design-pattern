using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise12
{
    public abstract class CommandBase
    {
        protected ToolStripMenuItem[] controls;
        protected CommandBase(params ToolStripMenuItem[] controls)
        {
            this.controls = controls;
        }

        public abstract void execute();
    }

    class EnableCommand : CommandBase
    {
        public EnableCommand(params ToolStripMenuItem[] controls): base(controls) { }
        public override void execute()
        {
            foreach(var ctrl in controls) {
                ctrl.Enabled = true;
            }
        }
    }
    class DisableCommand : CommandBase
    {
        public DisableCommand(params ToolStripMenuItem[] controls) : base(controls) { }
        public override void execute()
        {
            foreach (var ctrl in controls)
            {
                ctrl.Enabled = false;
            }
        }
    }

}
