using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationFramework.BasicValidation;
using ValidationFramework.LanguageFactory;

namespace ValidationFramework.Validation
{
    public class Phone : Validator
    {
        public Phone()
        {
            this.Code = 11;
        }
        public override bool check(string input, LanguageNotification l)
        {
            if (input.Length == 10 && input.IsNumberic())
            {
                return true;
            }
            this.Message = l.getErrorMessage(this.Code);
            return false;
        }
    }
}
