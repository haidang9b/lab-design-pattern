using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    public class StringStrategy : IValidation
    {
        public bool checkValidation(string str)
        {
            if(str.Length > 0)
            {
                return true;
            }
            return false;
        }
    }
}
