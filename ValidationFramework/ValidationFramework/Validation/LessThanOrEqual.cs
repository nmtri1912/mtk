using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationFramework.BasicValidation;
using ValidationFramework.LanguageFactory;

namespace ValidationFramework.Validation
{
    public class LessThanOrEqualTo : Validator
    {
        private int index;
        public LessThanOrEqualTo(int index)
        {
            this.Code = 6;
            this.index = index;
        }
        public override bool check(string input, LanguageNotification l)
        {
            try
            {
                int a = int.Parse(input);
                if (a.IsEqual(index) || a.IsLessThan(index))
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
