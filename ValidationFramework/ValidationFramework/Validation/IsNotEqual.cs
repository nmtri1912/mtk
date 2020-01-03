using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationFramework.LanguageFactory;

namespace ValidationFramework.Validation
{
    public class IsNotEqual : Validator
    {
        private string compare;

        public IsNotEqual(string compare)
        {
            this.Code = 16;
            this.compare = compare;
        }
        public override bool check(string input, LanguageNotification l)
        {
            if (!(string.Compare(input, this.compare) == 0))
            {
                return true;
            }

            this.Message = l.getErrorMessage(this.Code);
            return false;
        }
    }
}
