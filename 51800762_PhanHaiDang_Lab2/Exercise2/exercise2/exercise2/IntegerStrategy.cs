using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    public class IntegerStrategy : IValidation
    {
        public bool checkValidation(string str)
        {
            if(str.Length == 0)
            {
                return false;
            }
            if(int.TryParse(str, out int value))
            {
                return true;
            }
            return false;
        }
    }
}
