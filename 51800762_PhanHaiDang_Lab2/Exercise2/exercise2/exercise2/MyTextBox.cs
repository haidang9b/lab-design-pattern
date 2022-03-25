using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise2
{
    public class MyTextBox : TextBox
    {
        private ValidatorType _validatorType = ValidatorType.String;
        public IValidation validator;
        public ValidatorType validatorType
        {
            get => _validatorType;
            set
            {
                _validatorType = value;
                validator = SetAlgorithm();
            }
        }
        public MyTextBox()
        {

        }

        public IValidation SetAlgorithm()
        {
            switch (validatorType)
            {
                case ValidatorType.String:
                    return new StringStrategy();
                case ValidatorType.Integer:
                    return new IntegerStrategy();
                case ValidatorType.Double:
                    return new DoubleStrategy();
                case ValidatorType.Email:
                    return new EmailStrategy();
                case ValidatorType.Date:
                    return new DateStrategy();
                default:
                    return new StringStrategy();
            }

        }

        public bool runValidation()
        {
            return validator.checkValidation(this.Text);
        }
    }
}
