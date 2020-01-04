using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationFramework.BasicValidation
{
    public static class ValidateString
    {
        public static bool IsNotNullOrEmpty(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrEmpty(this string value)
        {
            return !value.IsNotNullOrEmpty();
        }

        public static bool IsNotNullOrWhiteSpace(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsBetweenLength(this string value, int min, int max)
        {
            return value.Length >= min && value.Length <= max; 
        }

        public static bool IsMaxLength(this string value, int max)
        {
            return value.Length <= max;
        }

        public static bool IsMinLength(this string value, int min)
        {
            return value.Length >= min;
        }

        public static bool IsExactLength(this string value, int length)
        {
            return value.Length == length;
        }

        public static bool IsEqualTo(this string value, string compare)
        {
            return string.Compare(value, compare) == 0;
        }

        public static bool IsNumberic(this string value)
        {
            foreach(char c in value)
            {
                if (c > '9' || c < '0') 
                {
                    return false;
                }
            }
            return true;
        }
    }
}
