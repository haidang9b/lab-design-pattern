using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    public class DoubleStrategy : IValidation
    {
        public bool checkValidation(string str)
        {
            if (str.Length == 0)
            {
                return false;
            }
            if (double.TryParse(str, out double value))
            {
                return true;
            }
            return false;
        }
    }
}
