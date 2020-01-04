using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationFramework.BasicValidation;
using ValidationFramework.LanguageFactory;

namespace ValidationFramework.Validation
{
    class ExclusiveBetween : Validator
    {
        private int from, to;
        public ExclusiveBetween(int from, int to)
        {
            this.from = from;
            this.to = to;
            this.Code = 9;
        }
        public override bool check(string input, LanguageNotification l)
        {
            try
            {
                int a = int.Parse(input);
                if (a.IsExclusiveBetween(from, to))
                {
                    return true;
                }

                this.Message = l.getErrorMessage(this.Code);
                return false;
            }
            catch
            {
                this.Message = l.getErrorMessage(this.Code);
                return false;
            }
        }
    }
}
