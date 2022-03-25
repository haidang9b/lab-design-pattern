using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public interface ICommand
    {
        void on();
        void off();
        string getName();
    }
}
