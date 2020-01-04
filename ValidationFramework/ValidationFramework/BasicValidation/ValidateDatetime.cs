using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ValidationFramework.BasicValidation
{
    public static class ValidateDatetime
    {
        //IsDate
        public static bool IsDate(this object value)
        {
            return value.IsDate(CultureInfo.InvariantCulture);
        }

        public static bool IsDate(this object value, CultureInfo info)
        {
            return value.IsDate(CultureInfo.InvariantCulture, DateTimeStyles.None);
        }

        public static bool IsDate(this object value, CultureInfo info, DateTimeStyles styles)
        {
            if (value.IsNotNull())
            {
                DateTime result;

                if (DateTime.TryParse(value.ToString(), info, styles, out result))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        // Date Comparisons 
        public static bool IsGreaterThan(this DateTime value, DateTime compare)
        {
            return value > compare;
        }

        public static bool IsGreaterThanOrEqualTo(this DateTime value, DateTime compare)
        {
            return value >= compare;
        }

        public static bool IsLessThan(this DateTime value, DateTime compare)
        {
            return value < compare;
        }

        public static bool IsLessThanOrEqualTo(this DateTime value, DateTime compare)
        {
            return value <= compare;
        }

        public static bool IsEqualTo(this DateTime value, DateTime compare)
        {
            return value == compare;
        }

        public static bool IsBetweenInclusive(this DateTime value, DateTime from, DateTime to)
        {
            return value >= from && value <= to;
        }

        public static bool IsBetweenExclusive(this DateTime value, DateTime from, DateTime to)
        {
            return value > from && value < to;
        }

    }
}
