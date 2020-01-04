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
            if (validator.check(input, l) == true)
            {
                if (addCheckCom(input, l) == true)
                {
                    return true;
                }
            }

            this.Message += validator.Message;
            return false;
        }

        private bool addCheckCom(string input, LanguageNotification l)
        {
            if (input.Length > 5)
            {
                if (input.Substring(input.Length - 4) == ".com")
                {
                    return true;
                }
                this.Message += "Email khong dung dinh dang .com";
                return false;
            }

            return false;
        }
    }
}
