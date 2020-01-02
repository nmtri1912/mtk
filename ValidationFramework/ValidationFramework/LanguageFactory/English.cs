using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationFramework.LanguageFactory
{
    class English : LanguageNotification
    {
        public string getErrorMessage(int code)
        {
            switch (code)
            {
                case 1:
                    return "This field is not empty";
                case 2:
                    return "This field is not Email";
                case 3:
                    return "'{0}' cannot be null.";
                case 4:
                    return "'{0}' cannot be null or empty.";
                case 5:
                    return "'{0}' cannot be null or whitespace only.";
                case 6:
                    return "'{0}' cannot be zero.";
                case 7:
                    return "'{0}' is not a valid password. Passwords must be 8 to 30 characters, at least on 1 uppercase letter, at least 1 lowercase letter and at least one number.";
                case 8:
                    return "'{0}' must be a at least {1} characters.";
                case 9:
                    return "'{0}' must be {1} characters or less.";
                case 10:
                    return "'{0}' must be exactly {1} characters.";
                case 11:
                    return "'{0}' must be at least {1} and at most {2} characters.";
                case 12:
                    return "'{0}' does not match the specified criteria.";
                case 13:
                    return "'{0}' does not match the specified criteria.";
                case 14:
                    return "'{0}' is not a valid email address.";
                case 15:
                    return "'{0}' does not match the provided regular expression.";
                case 16:
                    return "'{0}' did not match the specified criteria.";
                case 17:
                    return "'{0}' is not a valid date.";
                case 18:
                    return "'{0}' failed the provided business rule provided.";
                case 19:
                    return "'{0}' must be greater than '{1}'.";
                case 20:
                    return "'{0}' must be greater than or equal to '{1}'.";
                case 21:
                    return "'{0}' must be less than '{1}'.";
                case 22:
                    return "'{0}' must be less than or equal to '{1}'.";
                case 23:
                    return "'{0}' must be equal to '{1}'.";
                case 24:
                    return "'{0}' must be between '{1}' and '{2}' (inclusive).";
                case 25:
                    return "'{0}' must be between '{1}' and '{2}' (exclusive).";
            }
            return null;
        }
    }
}
