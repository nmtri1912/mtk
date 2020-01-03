using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationFramework.BasicValidation
{
    public static class ValidateInterger
    {
        public static bool IsNotZero(this int value)
        {
            return (value != 0);
        }

        public static bool IsEqual(this int value, int compare)
        {
            return (value == compare);
        }

        public static bool IsGreaterThan(this int value, int min)
        {
            return (value > min);
        }

        public static bool IsLessThan(this int value, int max)
        {
            return (value < max);
        }

        public static bool IsBetween(this int value, int min, int max)
        {
            return (value <= max && value >= min);
        }
    }
}
