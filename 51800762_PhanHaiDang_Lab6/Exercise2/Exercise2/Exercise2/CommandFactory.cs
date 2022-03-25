using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class CommandFactory
    {
        private static CommandFactory instance;
        public static CommandFactory getInstance()
        {
            if(instance == null)
            {
                instance = new CommandFactory();
            }
            return instance;
        }
        public ICommand createCommand(string name){
            if(name == "Light")
            {
                return new LightCommand(new Light());
            }
            else if(name == "Hottub")
            {
                return new HottubCommand(new Hottub());
            }
            else if(name == "TV")
            {
                return new TVCommand(new TV());
            }
            else if(name == "Outdoor light")
            {
                return new OutdoorLightCommand(new OutdoorLight());
            }
            else if( name == "Appliance control")
            {
                return new ApplianceControlCommand(new ApplianceControl());
            }
            return null;
        }
    }
}
