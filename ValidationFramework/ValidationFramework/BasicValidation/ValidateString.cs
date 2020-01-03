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
            return !value.IsNotNullOrWhiteSpace();
        }

        public static bool IsBetweenLength(this string value, int min, int max)
        {
            if (string.IsNullOrEmpty(value) && min == 0)
            {
                return true; // if it's null it has length 0
            }
            else if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            else
            {
                return value.Length >= min && value.Length <= max;
            }
        }

        public static bool IsMaxLength(this string value, int max)
        {
            if (string.IsNullOrEmpty(value))
            {
                return true; // if it's null it has length 0 and that has to be less than max
            }
            else
            {
                return value.Length <= max;
            }
        }

        public static bool IsMinLength(this string value, int min)
        {
            if (string.IsNullOrEmpty(value) && min == 0)
            {
                return true; // if it's null it has length 0
            }
            else if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            else
            {
                return value.Length >= min;
            }
        }

        public static bool IsExactLength(this string value, int length)
        {
            return value.IsBetweenLength(length, length);
        }

        public static bool IsEqualTo(this string value, string compare)
        {
            if (string.IsNullOrEmpty(value) && string.IsNullOrEmpty(compare))
            {
                return true;
            }
            if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(compare))
            {
                return false;
            }
            return String.Equals(value, compare, StringComparison.Ordinal);
        }

    }
}
