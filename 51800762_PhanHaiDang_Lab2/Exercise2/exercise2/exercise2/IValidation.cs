using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    public enum ValidatorType
    {
        String, Integer, Double, Email, Date
    }
    public interface IValidation
    {
        bool checkValidation(String str);
    }
}
