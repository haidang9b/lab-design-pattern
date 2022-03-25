using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemote simpleRemote = new SimpleRemote();

            Light light = new Light();
            TV tv = new TV();
            Hottub hottub = new Hottub();
            ApplianceControl appliance = new ApplianceControl();
            OutdoorLight outdoorLight = new OutdoorLight();

            simpleRemote.setOffCommand(1, new LightOffCommand(light));
            simpleRemote.setOnCommand(1, new LightOnCommand(light));

            simpleRemote.setOffCommand(2, new TVOffCommand(tv));
            simpleRemote.setOnCommand(2, new TVOnCommand(tv));

            simpleRemote.setOffCommand(3, new HottubOffCommand(hottub));
            simpleRemote.setOnCommand(3, new HottubOnCommand(hottub));

            simpleRemote.setOffCommand(4, new ApplianceControlOffCommand(appliance));
            simpleRemote.setOnCommand(4, new ApplianceControlOnCommand(appliance));

            simpleRemote.setOffCommand(5, new OutdoorLightOffCommand(outdoorLight));
            simpleRemote.setOnCommand(5, new OutdoorLightOnCommand(outdoorLight));


            Console.WriteLine("----Light----");
            simpleRemote.offButtonWasPushed(0);
            simpleRemote.onButtonWasPushed(0);
            simpleRemote.undoButtonWasPushed();
            simpleRemote.undoButtonWasPushed();
            simpleRemote.undoButtonWasPushed();

            Console.WriteLine("");
            Console.WriteLine("----Hottub----");
            simpleRemote.offButtonWasPushed(1);
            simpleRemote.onButtonWasPushed(1);

            simpleRemote.offButtonWasPushed(2);
            simpleRemote.onButtonWasPushed(2);
            Console.WriteLine("----Undo----");
            simpleRemote.undoButtonWasPushed();

            simpleRemote.onButtonWasPushed(3);

            simpleRemote.offButtonWasPushed(3);

            simpleRemote.onButtonWasPushed(4);
            simpleRemote.offButtonWasPushed(4);

            Console.WriteLine("");
            Console.WriteLine("----Undo----");
            simpleRemote.undoButtonWasPushed();
            simpleRemote.undoButtonWasPushed();
            simpleRemote.undoButtonWasPushed();
            simpleRemote.undoButtonWasPushed();
            simpleRemote.undoButtonWasPushed();
            simpleRemote.undoButtonWasPushed();
            simpleRemote.undoButtonWasPushed();
            simpleRemote.undoButtonWasPushed();
            Console.ReadKey();

        }
    }
}
