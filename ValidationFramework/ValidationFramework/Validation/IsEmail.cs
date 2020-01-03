using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationFramework.LanguageFactory;

namespace ValidationFramework.Validation
{
    public class IsEmail : Validator
    {
        public override bool check(string input, LanguageNotification l)
        {
            return base.check(input, l);
        }
         
    }
}
