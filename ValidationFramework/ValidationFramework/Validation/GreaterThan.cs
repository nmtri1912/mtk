using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationFramework.BasicValidation;
using ValidationFramework.LanguageFactory;

namespace ValidationFramework.Validation
{
    public class GreaterThan : Validator
    {
        private int index;
        public GreaterThan(int index)
        {
            this.Code = 3;
            this.index = index;
        }
        public override bool check(string input, LanguageNotification l)
        {
            try{
                int a = int.Parse(input);
                if(a.IsGreaterThan(index))
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
