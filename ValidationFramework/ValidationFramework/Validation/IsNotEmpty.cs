using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationFramework.LanguageFactory;

namespace ValidationFramework.Validation
{
    public class IsNotEmpty : Validator
    {
        public IsNotEmpty()
        {
            this.Code = 2;
        }

        public override bool check(string input, LanguageNotification l)
        {

            if (!string.IsNullOrEmpty(input))
            {
                this.Message = l.getErrorMessage(this.Code);
                return true;
            }
            return false;
        }
    }
}
