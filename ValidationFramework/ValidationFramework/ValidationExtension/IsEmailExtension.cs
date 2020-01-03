using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationFramework.LanguageFactory;
using ValidationFramework.Validation;

namespace ValidationFramework.ValidationExtension
{
    public class IsEmailExtension : ValidatorDecorator
    {

        public IsEmailExtension(Validator vali)
        {
            this.validator = vali;
        }
        public override bool check(string input, LanguageNotification l)
        {
            if (validator.check(input, l) == false)
            {
                return false;
            }

            if (addCheckNull(input, l) == true)
            {
                return true;
            }
            return false;
        }

        private bool addCheckNull(string input, LanguageNotification l)
        {
            IsNull isNull = new IsNull();
            if (isNull.check(input, l) == true)
            {
                validator.Message += "- {Add} ko duoc null";
            }
            return false;
        }
    }
}
