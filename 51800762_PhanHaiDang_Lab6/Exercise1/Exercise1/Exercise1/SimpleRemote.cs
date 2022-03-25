using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    enum CommandState
    {
        NOTSET,
        ON,
        OFF
    }
    class SimpleRemote
    {
        bool isUndo = false;
        Stack<ICommand> undoStack = new Stack<ICommand>();

        ICommand[] onCommands = new ICommand[5];
        ICommand[] offCommands = new ICommand[5];
        public SimpleRemote()
        {

        }
        public void setOnCommand(int index, ICommand command)
        {
            if(index > onCommands.Length || index <= 0)
            {
                Console.WriteLine("Vui lòng chọn vị trí cắm hợp lệ");
                return;
            }
            onCommands[index - 1] = command;
            
        }

        public void setOffCommand(int index, ICommand command)
        {
            if(index > offCommands.Length || index <= 0)
            {
                Console.WriteLine("Vui lòng chọn vị trí cắm hợp lệ");
                return;
            }
            offCommands[index - 1] = command;

        }
        public void onButtonWasPushed(int slot)
        {
            if (onCommands[slot] == null)
            {
                return;
            }
            onCommands[slot].execute();
            undoStack.Push(offCommands[slot]);
            isUndo = false;
        }

        public void offButtonWasPushed(int slot)
        {
            if(offCommands[slot] == null)
            {
                return;
            }
            offCommands[slot].execute();
            undoStack.Push(onCommands[slot]);
            isUndo = false;
        }

        public void undoButtonWasPushed()
        {
           
            if(undoStack.Count() != 0)
            {
                if (isUndo == false)
                {
                    undoStack.Pop();
                    isUndo = true;
                }
                if (isUndo)
                {
                    ICommand c = undoStack.Pop();
                    c.undo();
                }
                
            }
        }
    }
}
