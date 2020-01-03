using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationFramework.BasicValidation;
using ValidationFramework.LanguageFactory;

namespace ValidationFramework.Validation
{
    class IsPassword : Validator
    {
        public IsPassword()
        {
            this.Code = 14;
        }

        public override bool check(string input, LanguageNotification l)
        {
            if (input.IsPassword())
            {
                return true;
            }

            this.Message = l.getErrorMessage(this.Code);
            return false;
        }
    }
}
