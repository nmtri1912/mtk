using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationFramework.BasicValidation
{
    public static class ValidateObject
    {
        public static bool IsNotNull(this object value)
        {
            return (value != null);
        }
        public static bool IsNull(this object value)
        {
            return !value.IsNotNull();
        }
    }
}
