using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationFramework.LanguageFactory;

namespace ValidationFramework.Validation
{
    public class MaximumLength : Validator
    {
        private int max;
        public MaximumLength(int max)
        {
            this.Code = 7;
            this.max = max;
        }
        public override bool check(string input, LanguageNotification l)
        {
            if (input.Length <= max)
            {
                return true;
            }
            this.Message = l.getErrorMessage(this.Code);
            return false;
        }
    }
}
