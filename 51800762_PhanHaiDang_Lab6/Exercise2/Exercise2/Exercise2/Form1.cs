using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{

    public partial class Form1 : Form
    {

        private ICommand[] commands = new ICommand[7];
        private Stack<int> indexUndoStack = new Stack<int>();
        private Stack<string> stateUndoStack = new Stack<string>();
        private Label[] labels;
        public Form1()
        {
            InitializeComponent();
            labels = new Label[] { slot1, slot2, slot3, slot4, slot5, slot6, slot7 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if(item == null)
            {
                return;
            }
            var menu = item.Owner as ContextMenuStrip;
            var control = menu?.SourceControl as Label;
            if (item == null) { return; }
            var slot = int.Parse( control.Tag.ToString()) - 1;
            if(item.Text == "Clear")
            {
                commands[slot] = null;
                return;
            }

            commands[slot] = CommandFactory.getInstance().createCommand(item.Text);
            control.Text = commands[slot] == null ? "" : commands[slot].getName();
        }

        // turn on at here
        private void button1_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var slot = int.Parse(btn.Tag.ToString()) - 1;
            Console.WriteLine("Đang nhấn tại  "+ btn.Tag);
            if(commands[slot] == null)
            {
                return;
            }
            commands[slot].on();
            labels[slot].BackColor = Color.Green;
            indexUndoStack.Push(slot);
            stateUndoStack.Push("off");

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if (item == null)
            {
                return;
            }
            var menu = item.Owner as ContextMenuStrip;
            var control = menu?.SourceControl as Label;
            if (item == null) { return; }
            var slot = int.Parse(control.Tag.ToString()) - 1;
            if (item.Text == "Clear")
            {
                commands[slot] = null;
                return;
            }

            commands[slot] = CommandFactory.getInstance().createCommand(item.Text);
            control.Text = commands[slot] == null ? "" : commands[slot].getName();
        }

        private void hottubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if (item == null)
            {
                return;
            }
            var menu = item.Owner as ContextMenuStrip;
            var control = menu?.SourceControl as Label;
            if (item == null) { return; }
            var slot = int.Parse(control.Tag.ToString()) - 1;
            if (item.Text == "Clear")
            {
                commands[slot] = null;
                return;
            }

            commands[slot] = CommandFactory.getInstance().createCommand(item.Text);
            control.Text = commands[slot] == null ? "" : commands[slot].getName();
        }

        // turn off at here
        private void button8_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var slot = int.Parse(btn.Tag.ToString()) - 1;
            Console.WriteLine("Đang nhấn tại  " + btn.Tag);
            if (commands[slot] == null)
            {
                return;
            }
            commands[slot].off();
            labels[slot].BackColor = SystemColors.Control;
            indexUndoStack.Push(slot);
            stateUndoStack.Push("on");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if (item == null)
            {
                return;
            }
            var menu = item.Owner as ContextMenuStrip;
            var control = menu?.SourceControl as Label;
            if (item == null) { return; }
            var slot = int.Parse(control.Tag.ToString()) - 1;

            commands[slot] = null;
            control.Text = "";
            control.BackColor = SystemColors.Control;
        }

        private void outdoorLightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if (item == null)
            {
                return;
            }
            var menu = item.Owner as ContextMenuStrip;
            var control = menu?.SourceControl as Label;
            if (item == null) { return; }
            var slot = int.Parse(control.Tag.ToString()) - 1;
            if (item.Text == "Clear")
            {
                commands[slot] = null;
                return;
            }

            commands[slot] = CommandFactory.getInstance().createCommand(item.Text);
            control.Text = commands[slot] == null ? "" : commands[slot].getName();
        }

        private void applianceControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if (item == null)
            {
                return;
            }
            var menu = item.Owner as ContextMenuStrip;
            var control = menu?.SourceControl as Label;
            if (item == null) { return; }
            var slot = int.Parse(control.Tag.ToString()) - 1;
            if (item.Text == "Clear")
            {
                commands[slot] = null;
                return;
            }

            commands[slot] = CommandFactory.getInstance().createCommand(item.Text);
            control.Text = commands[slot] == null ? "" : commands[slot].getName();
        }

        // undo at here
        private void button15_Click(object sender, EventArgs e)
        {
            if(indexUndoStack.Count == 0 && stateUndoStack.Count == 0)
            {
                return;
            }
            var index = indexUndoStack.Pop();
            var state = stateUndoStack.Pop();

            if(commands[index] == null)
            {
                return;
            }
            if(state == "on")
            {
                commands[index].on();
                labels[index].BackColor = Color.Green;
                
            }
            else
            {
                commands[index].off();
                labels[index].BackColor = SystemColors.Control;
            }
        }
    }
}
