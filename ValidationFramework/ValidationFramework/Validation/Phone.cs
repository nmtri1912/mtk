using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (input[0] == 0 && input.Length == 10) 
            {
                return true;
            }
            this.Message = l.getErrorMessage(this.Code);
            return false;
        }
    }
}
