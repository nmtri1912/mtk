using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationFramework.LanguageFactory;

namespace ValidationFramework.Validation
{
    class MinimumLength : Validator
    {
        private int min;
        public MinimumLength(int min)
        {
            this.Code = 8;
            this.min = min;
        }
        public override bool check(string input, LanguageNotification l)
        {
            if (input.Length >= min)
            {
                return true;
            }
            this.Message = l.getErrorMessage(this.Code);
            return false;
        }
    }
}
