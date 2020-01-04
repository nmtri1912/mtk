using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationFramework.BasicValidation;
using ValidationFramework.LanguageFactory;

namespace ValidationFramework.Validation
{
    public class IsEmail : Validator
    {
        public IsEmail()
        {
            this.Code = 13;
        }
        public override bool check(string input, LanguageNotification l)
        {
            if(input.IsEmail())
            {
                return true;
            }

            this.Message = l.getErrorMessage(this.Code);
            return false;
        }
    }
}
