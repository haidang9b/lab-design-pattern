using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    public class EmailStrategy : IValidation
    {
        public bool checkValidation(string str)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(str);
                return addr.Address == str;
            }
            catch
            {
                return false;
            }
           
        }
    }
}
