using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationFramework.LanguageFactory;

namespace ValidationFramework.ValidationExtension
{
    public class PhoneExtension : ValidatorDecorator
    {
        public PhoneExtension(Validator vali)
        {
            this.validator = vali;
        }
        public override bool check(string input, LanguageNotification l)
        {
            if (validator.check(input, l) == true)
            {
                if (addCheckViettel(input, l) == true)
                {
                    return true;
                }
            }

            this.Message += validator.getMessage();
            return false;
        }

        private bool addCheckViettel(string input, LanguageNotification l)
        {
            if (input.Substring(0,3) == "086" || input.Substring(0, 3) == "096" || input.Substring(0, 3) == "097" || input.Substring(0, 3) == "098" ||
                input.Substring(0, 3) == "032" || input.Substring(0, 3) == "033" || input.Substring(0, 3) == "034" || input.Substring(0, 3) == "035" ||
                input.Substring(0, 3) == "036" || input.Substring(0, 3) == "037" || input.Substring(0, 3) == "038" || input.Substring(0, 3) == "039")
            {
                return true;
            }
            this.Message += "Khong phai dau so Viettel";
            return false;

        }
    }
}
