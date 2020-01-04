using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationFramework.LanguageFactory;

namespace ValidationFramework.Validation
{
    public class CreditCard : Validator
    {
        private int i, checkSum = 0;

        public CreditCard()
        {
            this.Code = 12;
        }
        public override bool check(string input, LanguageNotification l)
        {
            try 
            {
                if (input.Length != 0)
                {
                    //Tính tổng các chữ số từ chữ số thứ nhất bên phải qua cách nhau một chữ số
                    for (i = input.Length - 1; i >= 0; i -= 2)
                    {
                        this.checkSum += (input[i] - '0');
                    }

                    ////Tính tổng các chữ số từ chữ số thứ hai bên phải qua cách nhau một chữ số
                    for (i = input.Length - 2; i >= 0; i -= 2)
                    {
                        int val = ((input[i] - '0') * 2);
                        while (val > 0)
                        {
                            checkSum += (val % 10);
                            val /= 10;
                        }
                    }

                    if ((checkSum % 10) == 0)
                    {
                        return true;
                    }
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
