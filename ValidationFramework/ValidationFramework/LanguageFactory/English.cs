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
                    return "not an empty array";
                case 2:
                    return "is an empty array";
                case 3:
                    return "Not greater than";
                case 4:
                    return "Not greater than or equal to";
                case 5:
                    return "Not less than";
                case 6:
                    return "'Not less than or equal to";
                case 7:
                    return "Exceeded the allowed characters";
                case 8:
                    return "Too few characters";
                case 9:
                    return "Out of range";
                case 10:
                    return "Out of paragraph";
                case 11:
                    return "invalid phone number";
                case 12:
                    return "Invalid Credit Card";
                case 13:
                    return "Invalid email";
                case 14:
                    return "Minimum eight characters, at least one letter and one number";
                case 15:
                    return "Not equal to";
                case 16:
                    return "Already by";
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
